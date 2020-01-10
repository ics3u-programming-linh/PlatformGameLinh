namespace PlatformGameLinh
{
    partial class frmLose
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
            this.picLoseBkg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInstructions = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picLoseBkg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLoseBkg
            // 
            this.picLoseBkg.Image = global::PlatformGameLinh.Properties.Resources.losebkg;
            this.picLoseBkg.Location = new System.Drawing.Point(0, -1);
            this.picLoseBkg.Name = "picLoseBkg";
            this.picLoseBkg.Size = new System.Drawing.Size(486, 615);
            this.picLoseBkg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoseBkg.TabIndex = 0;
            this.picLoseBkg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlatformGameLinh.Properties.Resources.lose1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(133, 377);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(192, 74);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniInstructions});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(484, 24);
            this.mnuStrip.TabIndex = 6;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(38, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mniInstructions
            // 
            this.mniInstructions.Name = "mniInstructions";
            this.mniInstructions.Size = new System.Drawing.Size(81, 20);
            this.mniInstructions.Text = "Instructions";
            this.mniInstructions.Click += new System.EventHandler(this.MniInstructions_Click);
            // 
            // frmLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLoseBkg);
            this.Name = "frmLose";
            this.Text = "Platform Game";
            ((System.ComponentModel.ISupportInitialize)(this.picLoseBkg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoseBkg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniInstructions;
    }
}