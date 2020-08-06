namespace GUICardDealer
{
    partial class CardDealer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDealer));
            this.BackPic = new System.Windows.Forms.PictureBox();
            this.FrontPic = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.Restart = new System.Windows.Forms.Button();
            this.Cards_Left = new System.Windows.Forms.Label();
            this.Cards_Left_Box = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPic
            // 
            this.BackPic.Location = new System.Drawing.Point(12, 37);
            this.BackPic.Name = "BackPic";
            this.BackPic.Size = new System.Drawing.Size(75, 107);
            this.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackPic.TabIndex = 0;
            this.BackPic.TabStop = false;
            this.BackPic.Click += new System.EventHandler(this.BackPic_Click);
            // 
            // FrontPic
            // 
            this.FrontPic.Location = new System.Drawing.Point(102, 37);
            this.FrontPic.Name = "FrontPic";
            this.FrontPic.Size = new System.Drawing.Size(75, 107);
            this.FrontPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrontPic.TabIndex = 1;
            this.FrontPic.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "back-blue-75-1.png");
            this.imageList.Images.SetKeyName(1, "clubs-a-75.png");
            this.imageList.Images.SetKeyName(2, "clubs-2-75.png");
            this.imageList.Images.SetKeyName(3, "clubs-3-75.png");
            this.imageList.Images.SetKeyName(4, "clubs-4-75.png");
            this.imageList.Images.SetKeyName(5, "clubs-5-75.png");
            this.imageList.Images.SetKeyName(6, "clubs-6-75.png");
            this.imageList.Images.SetKeyName(7, "clubs-7-75.png");
            this.imageList.Images.SetKeyName(8, "clubs-8-75.png");
            this.imageList.Images.SetKeyName(9, "clubs-9-75.png");
            this.imageList.Images.SetKeyName(10, "clubs-10-75.png");
            this.imageList.Images.SetKeyName(11, "clubs-j-75.png");
            this.imageList.Images.SetKeyName(12, "clubs-q-75.png");
            this.imageList.Images.SetKeyName(13, "clubs-k-75.png");
            this.imageList.Images.SetKeyName(14, "diamonds-a-75.png");
            this.imageList.Images.SetKeyName(15, "diamonds-2-75.png");
            this.imageList.Images.SetKeyName(16, "diamonds-3-75.png");
            this.imageList.Images.SetKeyName(17, "diamonds-4-75.png");
            this.imageList.Images.SetKeyName(18, "diamonds-5-75.png");
            this.imageList.Images.SetKeyName(19, "diamonds-6-75.png");
            this.imageList.Images.SetKeyName(20, "diamonds-7-75.png");
            this.imageList.Images.SetKeyName(21, "diamonds-8-75.png");
            this.imageList.Images.SetKeyName(22, "diamonds-9-75.png");
            this.imageList.Images.SetKeyName(23, "diamonds-10-75.png");
            this.imageList.Images.SetKeyName(24, "diamonds-j-75.png");
            this.imageList.Images.SetKeyName(25, "diamonds-q-75.png");
            this.imageList.Images.SetKeyName(26, "diamonds-k-75.png");
            this.imageList.Images.SetKeyName(27, "hearts-a-75.png");
            this.imageList.Images.SetKeyName(28, "hearts-2-75.png");
            this.imageList.Images.SetKeyName(29, "hearts-3-75.png");
            this.imageList.Images.SetKeyName(30, "hearts-4-75.png");
            this.imageList.Images.SetKeyName(31, "hearts-5-75.png");
            this.imageList.Images.SetKeyName(32, "hearts-6-75.png");
            this.imageList.Images.SetKeyName(33, "hearts-7-75.png");
            this.imageList.Images.SetKeyName(34, "hearts-8-75.png");
            this.imageList.Images.SetKeyName(35, "hearts-9-75.png");
            this.imageList.Images.SetKeyName(36, "hearts-10-75.png");
            this.imageList.Images.SetKeyName(37, "hearts-j-75.png");
            this.imageList.Images.SetKeyName(38, "hearts-q-75.png");
            this.imageList.Images.SetKeyName(39, "hearts-k-75.png");
            this.imageList.Images.SetKeyName(40, "spades-a-75.png");
            this.imageList.Images.SetKeyName(41, "spades-2-75.png");
            this.imageList.Images.SetKeyName(42, "spades-3-75.png");
            this.imageList.Images.SetKeyName(43, "spades-4-75.png");
            this.imageList.Images.SetKeyName(44, "spades-5-75.png");
            this.imageList.Images.SetKeyName(45, "spades-6-75.png");
            this.imageList.Images.SetKeyName(46, "spades-7-75.png");
            this.imageList.Images.SetKeyName(47, "spades-8-75.png");
            this.imageList.Images.SetKeyName(48, "spades-9-75.png");
            this.imageList.Images.SetKeyName(49, "spades-10-75.png");
            this.imageList.Images.SetKeyName(50, "spades-j-75.png");
            this.imageList.Images.SetKeyName(51, "spades-q-75.png");
            this.imageList.Images.SetKeyName(52, "spades-k-75.png");
            this.imageList.Images.SetKeyName(53, "images.png");
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(52, 152);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 2;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Cards_Left
            // 
            this.Cards_Left.AutoSize = true;
            this.Cards_Left.Location = new System.Drawing.Point(92, 14);
            this.Cards_Left.Name = "Cards_Left";
            this.Cards_Left.Size = new System.Drawing.Size(54, 13);
            this.Cards_Left.TabIndex = 4;
            this.Cards_Left.Text = "Cards left:";
            // 
            // Cards_Left_Box
            // 
            this.Cards_Left_Box.AutoSize = true;
            this.Cards_Left_Box.Location = new System.Drawing.Point(142, 14);
            this.Cards_Left_Box.Name = "Cards_Left_Box";
            this.Cards_Left_Box.Size = new System.Drawing.Size(0, 13);
            this.Cards_Left_Box.TabIndex = 5;
            // 
            // CardDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(190, 185);
            this.Controls.Add(this.Cards_Left_Box);
            this.Controls.Add(this.Cards_Left);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.FrontPic);
            this.Controls.Add(this.BackPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CardDealer";
            this.Text = "CardDealer";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackPic;
        private System.Windows.Forms.PictureBox FrontPic;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label Cards_Left;
        private System.Windows.Forms.Label Cards_Left_Box;
    }
}

