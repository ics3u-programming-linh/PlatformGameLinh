namespace PlatformGameLinh
{
    partial class frmMainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInstructions = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlatformGameLinh.Properties.Resources.menuBackground;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLevel1
            // 
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.Location = new System.Drawing.Point(142, 136);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(186, 66);
            this.btnLevel1.TabIndex = 1;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.BtnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.Location = new System.Drawing.Point(142, 238);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(186, 66);
            this.btnLevel2.TabIndex = 2;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = true;
            // 
            // btnLevel3
            // 
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel3.Location = new System.Drawing.Point(142, 342);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(186, 66);
            this.btnLevel3.TabIndex = 3;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = true;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniInstructions});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(484, 24);
            this.mnuStrip.TabIndex = 4;
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
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniInstructions;
    }
}