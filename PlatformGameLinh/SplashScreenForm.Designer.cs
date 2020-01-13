namespace PlatformGameLinh
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.wmpBackground = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mniCredits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniRestart,
            this.mniInstructions,
            this.mniCredits});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(484, 24);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(37, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mniRestart
            // 
            this.mniRestart.Name = "mniRestart";
            this.mniRestart.Size = new System.Drawing.Size(55, 20);
            this.mniRestart.Text = "Restart";
            this.mniRestart.Click += new System.EventHandler(this.mniRestart_Click);
            // 
            // mniInstructions
            // 
            this.mniInstructions.Name = "mniInstructions";
            this.mniInstructions.Size = new System.Drawing.Size(81, 20);
            this.mniInstructions.Text = "Instructions";
            this.mniInstructions.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "HO GAMES";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(145, 302);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 89);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrStart
            // 
            this.tmrStart.Enabled = true;
            this.tmrStart.Interval = 2000;
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // wmpBackground
            // 
            this.wmpBackground.Enabled = true;
            this.wmpBackground.Location = new System.Drawing.Point(345, 428);
            this.wmpBackground.Name = "wmpBackground";
            this.wmpBackground.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpBackground.OcxState")));
            this.wmpBackground.Size = new System.Drawing.Size(75, 23);
            this.wmpBackground.TabIndex = 4;
            this.wmpBackground.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlatformGameLinh.Properties.Resources.HomeBackground;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mniCredits
            // 
            this.mniCredits.Name = "mniCredits";
            this.mniCredits.Size = new System.Drawing.Size(56, 20);
            this.mniCredits.Text = "Credits";
            this.mniCredits.Click += new System.EventHandler(this.mniCredits_Click);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.wmpBackground);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmSplashScreen";
            this.Text = "Platform Game by Linh Ho";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.ToolStripMenuItem mniInstructions;
        private AxWMPLib.AxWindowsMediaPlayer wmpBackground;
        private System.Windows.Forms.ToolStripMenuItem mniCredits;
    }
}