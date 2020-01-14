namespace PlatformGameLinh
{
    partial class frmLevel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel1));
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.wmpChime = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpLoseLife = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpDoor = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picHeart3 = new System.Windows.Forms.PictureBox();
            this.picHeart2 = new System.Windows.Forms.PictureBox();
            this.picHeart1 = new System.Windows.Forms.PictureBox();
            this.picPlatform7 = new System.Windows.Forms.PictureBox();
            this.picPlatform6 = new System.Windows.Forms.PictureBox();
            this.picPlatform5 = new System.Windows.Forms.PictureBox();
            this.picPlatform4 = new System.Windows.Forms.PictureBox();
            this.picPlatform3 = new System.Windows.Forms.PictureBox();
            this.picPlatform2 = new System.Windows.Forms.PictureBox();
            this.picPlatform1 = new System.Windows.Forms.PictureBox();
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picPlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpChime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLoseLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(79, 20);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "Time Left:";
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(111, 280);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(260, 65);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnLevel2_Click);
            // 
            // wmpChime
            // 
            this.wmpChime.Enabled = true;
            this.wmpChime.Location = new System.Drawing.Point(273, 522);
            this.wmpChime.Name = "wmpChime";
            this.wmpChime.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpChime.OcxState")));
            this.wmpChime.Size = new System.Drawing.Size(223, 91);
            this.wmpChime.TabIndex = 23;
            this.wmpChime.Visible = false;
            // 
            // wmpLoseLife
            // 
            this.wmpLoseLife.Enabled = true;
            this.wmpLoseLife.Location = new System.Drawing.Point(263, 524);
            this.wmpLoseLife.Name = "wmpLoseLife";
            this.wmpLoseLife.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLoseLife.OcxState")));
            this.wmpLoseLife.Size = new System.Drawing.Size(223, 91);
            this.wmpLoseLife.TabIndex = 24;
            this.wmpLoseLife.Visible = false;
            // 
            // wmpDoor
            // 
            this.wmpDoor.Enabled = true;
            this.wmpDoor.Location = new System.Drawing.Point(135, 484);
            this.wmpDoor.Name = "wmpDoor";
            this.wmpDoor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpDoor.OcxState")));
            this.wmpDoor.Size = new System.Drawing.Size(223, 91);
            this.wmpDoor.TabIndex = 25;
            this.wmpDoor.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.pictureBox5.Location = new System.Drawing.Point(218, 190);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.pictureBox4.Location = new System.Drawing.Point(191, 546);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "coin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.pictureBox3.Location = new System.Drawing.Point(72, 546);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.pictureBox2.Location = new System.Drawing.Point(88, 385);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // picCoin
            // 
            this.picCoin.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.picCoin.Location = new System.Drawing.Point(242, 454);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(41, 29);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 18;
            this.picCoin.TabStop = false;
            this.picCoin.Tag = "coin";
            // 
            // picHeart3
            // 
            this.picHeart3.BackColor = System.Drawing.Color.Transparent;
            this.picHeart3.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart3.Location = new System.Drawing.Point(431, 9);
            this.picHeart3.Name = "picHeart3";
            this.picHeart3.Size = new System.Drawing.Size(53, 45);
            this.picHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart3.TabIndex = 14;
            this.picHeart3.TabStop = false;
            // 
            // picHeart2
            // 
            this.picHeart2.BackColor = System.Drawing.Color.Transparent;
            this.picHeart2.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart2.Location = new System.Drawing.Point(374, 9);
            this.picHeart2.Name = "picHeart2";
            this.picHeart2.Size = new System.Drawing.Size(53, 45);
            this.picHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart2.TabIndex = 13;
            this.picHeart2.TabStop = false;
            // 
            // picHeart1
            // 
            this.picHeart1.BackColor = System.Drawing.Color.Transparent;
            this.picHeart1.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart1.Location = new System.Drawing.Point(318, 9);
            this.picHeart1.Name = "picHeart1";
            this.picHeart1.Size = new System.Drawing.Size(53, 45);
            this.picHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart1.TabIndex = 12;
            this.picHeart1.TabStop = false;
            // 
            // picPlatform7
            // 
            this.picPlatform7.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform7.Location = new System.Drawing.Point(191, 85);
            this.picPlatform7.Name = "picPlatform7";
            this.picPlatform7.Size = new System.Drawing.Size(151, 29);
            this.picPlatform7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform7.TabIndex = 10;
            this.picPlatform7.TabStop = false;
            this.picPlatform7.Tag = "platform";
            // 
            // picPlatform6
            // 
            this.picPlatform6.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform6.Location = new System.Drawing.Point(-22, 154);
            this.picPlatform6.Name = "picPlatform6";
            this.picPlatform6.Size = new System.Drawing.Size(151, 29);
            this.picPlatform6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform6.TabIndex = 9;
            this.picPlatform6.TabStop = false;
            this.picPlatform6.Tag = "platform";
            // 
            // picPlatform5
            // 
            this.picPlatform5.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform5.Location = new System.Drawing.Point(173, 228);
            this.picPlatform5.Name = "picPlatform5";
            this.picPlatform5.Size = new System.Drawing.Size(151, 29);
            this.picPlatform5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform5.TabIndex = 8;
            this.picPlatform5.TabStop = false;
            this.picPlatform5.Tag = "platform";
            // 
            // picPlatform4
            // 
            this.picPlatform4.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform4.Location = new System.Drawing.Point(-22, 316);
            this.picPlatform4.Name = "picPlatform4";
            this.picPlatform4.Size = new System.Drawing.Size(151, 29);
            this.picPlatform4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform4.TabIndex = 7;
            this.picPlatform4.TabStop = false;
            this.picPlatform4.Tag = "platform";
            // 
            // picPlatform3
            // 
            this.picPlatform3.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform3.Location = new System.Drawing.Point(345, 316);
            this.picPlatform3.Name = "picPlatform3";
            this.picPlatform3.Size = new System.Drawing.Size(151, 29);
            this.picPlatform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform3.TabIndex = 6;
            this.picPlatform3.TabStop = false;
            this.picPlatform3.Tag = "platform";
            // 
            // picPlatform2
            // 
            this.picPlatform2.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform2.Location = new System.Drawing.Point(62, 420);
            this.picPlatform2.Name = "picPlatform2";
            this.picPlatform2.Size = new System.Drawing.Size(151, 29);
            this.picPlatform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform2.TabIndex = 5;
            this.picPlatform2.TabStop = false;
            this.picPlatform2.Tag = "platform";
            // 
            // picPlatform1
            // 
            this.picPlatform1.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform1.Location = new System.Drawing.Point(207, 489);
            this.picPlatform1.Name = "picPlatform1";
            this.picPlatform1.Size = new System.Drawing.Size(151, 29);
            this.picPlatform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlatform1.TabIndex = 4;
            this.picPlatform1.TabStop = false;
            this.picPlatform1.Tag = "platform";
            // 
            // picDoor
            // 
            this.picDoor.Image = global::PlatformGameLinh.Properties.Resources.door;
            this.picDoor.Location = new System.Drawing.Point(234, 4);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(49, 81);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 3;
            this.picDoor.TabStop = false;
            this.picDoor.Tag = "door";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::PlatformGameLinh.Properties.Resources.player;
            this.picPlayer.Location = new System.Drawing.Point(414, 420);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(58, 50);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            // 
            // picPlatform
            // 
            this.picPlatform.Image = global::PlatformGameLinh.Properties.Resources.platform;
            this.picPlatform.Location = new System.Drawing.Point(-22, 581);
            this.picPlatform.Name = "picPlatform";
            this.picPlatform.Size = new System.Drawing.Size(705, 298);
            this.picPlatform.TabIndex = 1;
            this.picPlatform.TabStop = false;
            this.picPlatform.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlatformGameLinh.Properties.Resources.Level1Background;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 20;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // frmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 611);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picHeart3);
            this.Controls.Add(this.picHeart2);
            this.Controls.Add(this.picHeart1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picPlatform7);
            this.Controls.Add(this.picPlatform6);
            this.Controls.Add(this.picPlatform5);
            this.Controls.Add(this.picPlatform4);
            this.Controls.Add(this.picPlatform3);
            this.Controls.Add(this.picPlatform2);
            this.Controls.Add(this.picPlatform1);
            this.Controls.Add(this.picDoor);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picPlatform);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wmpDoor);
            this.Controls.Add(this.wmpLoseLife);
            this.Controls.Add(this.wmpChime);
            this.Name = "frmLevel1";
            this.Text = "Level 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.wmpChime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLoseLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPlatform;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picDoor;
        private System.Windows.Forms.PictureBox picPlatform1;
        private System.Windows.Forms.PictureBox picPlatform2;
        private System.Windows.Forms.PictureBox picPlatform3;
        private System.Windows.Forms.PictureBox picPlatform4;
        private System.Windows.Forms.PictureBox picPlatform5;
        private System.Windows.Forms.PictureBox picPlatform6;
        private System.Windows.Forms.PictureBox picPlatform7;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.PictureBox picHeart1;
        private System.Windows.Forms.PictureBox picHeart2;
        private System.Windows.Forms.PictureBox picHeart3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private AxWMPLib.AxWindowsMediaPlayer wmpChime;
        private AxWMPLib.AxWindowsMediaPlayer wmpLoseLife;
        private AxWMPLib.AxWindowsMediaPlayer wmpDoor;
        private System.Windows.Forms.Timer tmrTimer;
    }
}

