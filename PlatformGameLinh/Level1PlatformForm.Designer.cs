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
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picLoseScreen = new System.Windows.Forms.PictureBox();
            this.picWin = new System.Windows.Forms.PictureBox();
            this.picWinLoseScreen = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picLoseScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinLoseScreen)).BeginInit();
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
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 20;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(110, 21);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "Time Left:";
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Enabled = true;
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.Location = new System.Drawing.Point(249, 411);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(133, 38);
            this.btnLevel2.TabIndex = 17;
            this.btnLevel2.Text = "Next";
            this.btnLevel2.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(74, 420);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(48, 16);
            this.lblPoints.TabIndex = 18;
            this.lblPoints.Text = "Points:";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(249, 411);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(133, 38);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picLoseScreen
            // 
            this.picLoseScreen.Image = global::PlatformGameLinh.Properties.Resources.lose1;
            this.picLoseScreen.Location = new System.Drawing.Point(74, 180);
            this.picLoseScreen.Name = "picLoseScreen";
            this.picLoseScreen.Size = new System.Drawing.Size(353, 191);
            this.picLoseScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoseScreen.TabIndex = 20;
            this.picLoseScreen.TabStop = false;
            // 
            // picWin
            // 
            this.picWin.Image = global::PlatformGameLinh.Properties.Resources.win;
            this.picWin.Location = new System.Drawing.Point(74, 180);
            this.picWin.Name = "picWin";
            this.picWin.Size = new System.Drawing.Size(353, 191);
            this.picWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWin.TabIndex = 16;
            this.picWin.TabStop = false;
            // 
            // picWinLoseScreen
            // 
            this.picWinLoseScreen.BackColor = System.Drawing.Color.Transparent;
            this.picWinLoseScreen.Location = new System.Drawing.Point(32, 120);
            this.picWinLoseScreen.Name = "picWinLoseScreen";
            this.picWinLoseScreen.Size = new System.Drawing.Size(425, 373);
            this.picWinLoseScreen.TabIndex = 15;
            this.picWinLoseScreen.TabStop = false;
            // 
            // picHeart3
            // 
            this.picHeart3.Image = global::PlatformGameLinh.Properties.Resources.heart;
            this.picHeart3.Location = new System.Drawing.Point(433, 9);
            this.picHeart3.Name = "picHeart3";
            this.picHeart3.Size = new System.Drawing.Size(53, 45);
            this.picHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeart3.TabIndex = 14;
            this.picHeart3.TabStop = false;
            // 
            // picHeart2
            // 
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
            // frmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.picLoseScreen);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.picWin);
            this.Controls.Add(this.picWinLoseScreen);
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
            this.Name = "frmLevel1";
            this.Text = "Level 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picLoseScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinLoseScreen)).EndInit();
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
        private System.Windows.Forms.Timer tmrTimer;
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
        private System.Windows.Forms.PictureBox picWinLoseScreen;
        private System.Windows.Forms.PictureBox picWin;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picLoseScreen;
    }
}

