using System;
using System.Collections.Generic;
using System.Drawing;
using PlayingCard;

namespace GUICardDealer
{
    public partial class CardDealer : System.Windows.Forms.Form
    {
        Deck deck;
        public CardDealer()
        {
            InitializeComponent();
        }
        

        private void Form_Load(object sender, EventArgs e)
        {
            SetComponents();
        }

        private void BackPic_Click(object sender, EventArgs e)
        {
            PlayingCards card = deck.DealTopCard();

            BackPic.Image =  (!deck.IsEmpty()) ? card.BackImage : imageList.Images[55];
            BackPic.Enabled = (!deck.IsEmpty()) ? true : false;
            FrontPic.Image = card.FrontImage;

            Cards_Left_Box.Text = string.Format("{0}", deck.cards.Count);
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            SetComponents();
        }

        public void SetComponents()
        {
            BackPic.Enabled = true;

            deck = new Deck();
            List<Image> images = new List<Image>();

            for (int i = 1; i <= 52; i++)
            {
                images.Add(imageList.Images[i]);
            }
            deck.AssignImage(images, imageList.Images[0]);

            deck.Shuffle();

            BackPic.Image = imageList.Images[0];
            FrontPic.Image = null;
            Cards_Left_Box.Text = string.Format("{0}", deck.cards.Count);
        }
    }
}
