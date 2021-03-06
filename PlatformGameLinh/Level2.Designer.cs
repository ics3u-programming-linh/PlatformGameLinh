﻿namespace PlatformGameLinh
{
    partial class frmLevel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevel2));
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.wmpChime = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpDoor = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpLoseLife = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picSad4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picSad3 = new System.Windows.Forms.PictureBox();
            this.picSad2 = new System.Windows.Forms.PictureBox();
            this.picSad1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picPlatform9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picPlatform3 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.picHeart3 = new System.Windows.Forms.PictureBox();
            this.picHeart2 = new System.Windows.Forms.PictureBox();
            this.picHeart1 = new System.Windows.Forms.PictureBox();
            this.picPlatform1 = new System.Windows.Forms.PictureBox();
            this.picPlatform6 = new System.Windows.Forms.PictureBox();
            this.picPlatform2 = new System.Windows.Forms.PictureBox();
            this.picPlatform5 = new System.Windows.Forms.PictureBox();
            this.picPlatform8 = new System.Windows.Forms.PictureBox();
            this.picPlatform4 = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.wall2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpChime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLoseLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 20;
            this.tmrTimer.Tick += new System.EventHandler(this.TmrTimer_Tick);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.TmrCountdown_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(111, 280);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(260, 65);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(79, 20);
            this.lblTimer.TabIndex = 19;
            this.lblTimer.Text = "Time Left:";
            // 
            // wmpChime
            // 
            this.wmpChime.Enabled = true;
            this.wmpChime.Location = new System.Drawing.Point(408, 356);
            this.wmpChime.Name = "wmpChime";
            this.wmpChime.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpChime.OcxState")));
            this.wmpChime.Size = new System.Drawing.Size(75, 23);
            this.wmpChime.TabIndex = 23;
            this.wmpChime.Visible = false;
            // 
            // wmpDoor
            // 
            this.wmpDoor.Enabled = true;
            this.wmpDoor.Location = new System.Drawing.Point(413, 397);
            this.wmpDoor.Name = "wmpDoor";
            this.wmpDoor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpDoor.OcxState")));
            this.wmpDoor.Size = new System.Drawing.Size(75, 23);
            this.wmpDoor.TabIndex = 24;
            this.wmpDoor.Visible = false;
            // 
            // wmpLoseLife
            // 
            this.wmpLoseLife.Enabled = true;
            this.wmpLoseLife.Location = new System.Drawing.Point(413, 454);
            this.wmpLoseLife.Name = "wmpLoseLife";
            this.wmpLoseLife.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLoseLife.OcxState")));
            this.wmpLoseLife.Size = new System.Drawing.Size(75, 23);
            this.wmpLoseLife.TabIndex = 25;
            this.wmpLoseLife.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 31);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 20);
            this.lblScore.TabIndex = 38;
            this.lblScore.Text = "Score: ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.pictureBox5.Location = new System.Drawing.Point(332, 527);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            // 
            // picSad4
            // 
            this.picSad4.Image = global::PlatformGameLinh.Properties.Resources.loselife;
            this.picSad4.Location = new System.Drawing.Point(37, 60);
            this.picSad4.Name = "picSad4";
            this.picSad4.Size = new System.Drawing.Size(55, 43);
            this.picSad4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSad4.TabIndex = 34;
            this.picSad4.TabStop = false;
            this.picSad4.Tag = "sad";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.pictureBox3.Location = new System.Drawing.Point(376, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 15);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // picSad3
            // 
            this.picSad3.Image = global::PlatformGameLinh.Properties.Resources.loselife;
            this.picSad3.Location = new System.Drawing.Point(17, 357);
            this.picSad3.Name = "picSad3";
            this.picSad3.Size = new System.Drawing.Size(55, 43);
            this.picSad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSad3.TabIndex = 32;
            this.picSad3.TabStop = false;
            this.picSad3.Tag = "sad";
            // 
            // picSad2
            // 
            this.picSad2.Image = global::PlatformGameLinh.Properties.Resources.loselife;
            this.picSad2.Location = new System.Drawing.Point(17, 533);
            this.picSad2.Name = "picSad2";
            this.picSad2.Size = new System.Drawing.Size(55, 43);
            this.picSad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSad2.TabIndex = 31;
            this.picSad2.TabStop = false;
            this.picSad2.Tag = "sad";
            // 
            // picSad1
            // 
            this.picSad1.Image = global::PlatformGameLinh.Properties.Resources.loselife;
            this.picSad1.Location = new System.Drawing.Point(388, 239);
            this.picSad1.Name = "picSad1";
            this.picSad1.Size = new System.Drawing.Size(55, 43);
            this.picSad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSad1.TabIndex = 30;
            this.picSad1.TabStop = false;
            this.picSad1.Tag = "sad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.pictureBox2.Location = new System.Drawing.Point(396, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 23);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // picPlatform9
            // 
            this.picPlatform9.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform9.Location = new System.Drawing.Point(-4, 398);
            this.picPlatform9.Name = "picPlatform9";
            this.picPlatform9.Size = new System.Drawing.Size(92, 23);
            this.picPlatform9.TabIndex = 28;
            this.picPlatform9.TabStop = false;
            this.picPlatform9.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(211, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // picCoin
            // 
            this.picCoin.Image = global::PlatformGameLinh.Properties.Resources.coin;
            this.picCoin.Location = new System.Drawing.Point(211, 427);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(41, 29);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 26;
            this.picCoin.TabStop = false;
            this.picCoin.Tag = "coin";
            // 
            // picPlatform3
            // 
            this.picPlatform3.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform3.Location = new System.Drawing.Point(359, 281);
            this.picPlatform3.Name = "picPlatform3";
            this.picPlatform3.Size = new System.Drawing.Size(125, 30);
            this.picPlatform3.TabIndex = 22;
            this.picPlatform3.TabStop = false;
            this.picPlatform3.Tag = "platform";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::PlatformGameLinh.Properties.Resources.player;
            this.picPlayer.Location = new System.Drawing.Point(409, 341);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(60, 51);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 21;
            this.picPlayer.TabStop = false;
            // 
            // picDoor
            // 
            this.picDoor.Image = global::PlatformGameLinh.Properties.Resources.door;
            this.picDoor.Location = new System.Drawing.Point(409, 74);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(61, 72);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 20;
            this.picDoor.TabStop = false;
            // 
            // picHeart3
            // 
            this.picHeart3.BackColor = System.Drawing.Color.Transparent;
            this.picHeart3.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart3.Location = new System.Drawing.Point(431, 13);
            this.picHeart3.Name = "picHeart3";
            this.picHeart3.Size = new System.Drawing.Size(53, 45);
            this.picHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart3.TabIndex = 15;
            this.picHeart3.TabStop = false;
            // 
            // picHeart2
            // 
            this.picHeart2.BackColor = System.Drawing.Color.Transparent;
            this.picHeart2.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart2.Location = new System.Drawing.Point(376, 13);
            this.picHeart2.Name = "picHeart2";
            this.picHeart2.Size = new System.Drawing.Size(53, 45);
            this.picHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart2.TabIndex = 14;
            this.picHeart2.TabStop = false;
            // 
            // picHeart1
            // 
            this.picHeart1.BackColor = System.Drawing.Color.Transparent;
            this.picHeart1.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart1.Location = new System.Drawing.Point(320, 13);
            this.picHeart1.Name = "picHeart1";
            this.picHeart1.Size = new System.Drawing.Size(53, 45);
            this.picHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart1.TabIndex = 13;
            this.picHeart1.TabStop = false;
            // 
            // picPlatform1
            // 
            this.picPlatform1.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform1.Location = new System.Drawing.Point(0, 576);
            this.picPlatform1.Name = "picPlatform1";
            this.picPlatform1.Size = new System.Drawing.Size(489, 37);
            this.picPlatform1.TabIndex = 10;
            this.picPlatform1.TabStop = false;
            this.picPlatform1.Tag = "platform";
            // 
            // picPlatform6
            // 
            this.picPlatform6.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform6.Location = new System.Drawing.Point(179, 167);
            this.picPlatform6.Name = "picPlatform6";
            this.picPlatform6.Size = new System.Drawing.Size(117, 30);
            this.picPlatform6.TabIndex = 6;
            this.picPlatform6.TabStop = false;
            this.picPlatform6.Tag = "platform";
            // 
            // picPlatform2
            // 
            this.picPlatform2.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform2.Location = new System.Drawing.Point(161, 462);
            this.picPlatform2.Name = "picPlatform2";
            this.picPlatform2.Size = new System.Drawing.Size(135, 30);
            this.picPlatform2.TabIndex = 4;
            this.picPlatform2.TabStop = false;
            this.picPlatform2.Tag = "platform";
            // 
            // picPlatform5
            // 
            this.picPlatform5.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform5.Location = new System.Drawing.Point(211, 309);
            this.picPlatform5.Name = "picPlatform5";
            this.picPlatform5.Size = new System.Drawing.Size(42, 30);
            this.picPlatform5.TabIndex = 3;
            this.picPlatform5.TabStop = false;
            this.picPlatform5.Tag = "platform";
            // 
            // picPlatform8
            // 
            this.picPlatform8.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform8.Location = new System.Drawing.Point(0, 103);
            this.picPlatform8.Name = "picPlatform8";
            this.picPlatform8.Size = new System.Drawing.Size(148, 30);
            this.picPlatform8.TabIndex = 2;
            this.picPlatform8.TabStop = false;
            this.picPlatform8.Tag = "platform";
            // 
            // picPlatform4
            // 
            this.picPlatform4.Image = global::PlatformGameLinh.Properties.Resources.platform2;
            this.picPlatform4.Location = new System.Drawing.Point(0, 245);
            this.picPlatform4.Name = "picPlatform4";
            this.picPlatform4.Size = new System.Drawing.Size(125, 30);
            this.picPlatform4.TabIndex = 1;
            this.picPlatform4.TabStop = false;
            this.picPlatform4.Tag = "platform";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::PlatformGameLinh.Properties.Resources.Level2;
            this.picBackground.Location = new System.Drawing.Point(-39, -17);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(545, 687);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // wall1
            // 
            this.wall1.Image = global::PlatformGameLinh.Properties.Resources.Level1Background;
            this.wall1.Location = new System.Drawing.Point(0, -2);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(10, 578);
            this.wall1.TabIndex = 36;
            this.wall1.TabStop = false;
            // 
            // wall2
            // 
            this.wall2.Image = global::PlatformGameLinh.Properties.Resources.Level1Background;
            this.wall2.Location = new System.Drawing.Point(487, 0);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(10, 578);
            this.wall2.TabIndex = 37;
            this.wall2.TabStop = false;
            // 
            // frmLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picSad4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picSad3);
            this.Controls.Add(this.picSad2);
            this.Controls.Add(this.picSad1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picPlatform9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picPlatform3);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picDoor);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picHeart3);
            this.Controls.Add(this.picHeart2);
            this.Controls.Add(this.picHeart1);
            this.Controls.Add(this.picPlatform1);
            this.Controls.Add(this.picPlatform6);
            this.Controls.Add(this.picPlatform2);
            this.Controls.Add(this.picPlatform5);
            this.Controls.Add(this.picPlatform8);
            this.Controls.Add(this.picPlatform4);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.wmpChime);
            this.Controls.Add(this.wmpDoor);
            this.Controls.Add(this.wmpLoseLife);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall2);
            this.Name = "frmLevel2";
            this.Text = "Level 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.wmpChime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLoseLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.PictureBox picPlatform4;
        private System.Windows.Forms.PictureBox picPlatform8;
        private System.Windows.Forms.PictureBox picPlatform5;
        private System.Windows.Forms.PictureBox picPlatform2;
        private System.Windows.Forms.PictureBox picPlatform6;
        private System.Windows.Forms.PictureBox picPlatform1;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.PictureBox picHeart1;
        private System.Windows.Forms.PictureBox picHeart2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picDoor;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picPlatform3;
        private AxWMPLib.AxWindowsMediaPlayer wmpChime;
        private AxWMPLib.AxWindowsMediaPlayer wmpDoor;
        private AxWMPLib.AxWindowsMediaPlayer wmpLoseLife;
        private System.Windows.Forms.PictureBox picHeart3;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPlatform9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picSad1;
        private System.Windows.Forms.PictureBox picSad2;
        private System.Windows.Forms.PictureBox picSad3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picSad4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.Label lblScore;
    }
}