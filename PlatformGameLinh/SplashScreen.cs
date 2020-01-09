﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGameLinh
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            btnStart.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit application
            this.Close();
        }

        private void mniRestart_Click(object sender, EventArgs e)
        {
            // restart application
            Application.Restart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // close this form and open level 1 form
            this.Hide();
            var Level1 = new frmLevel1();
            Level1.Closed += (s, args) => this.Close();
            Level1.Show();
        }
        private void tmrStart_Tick(object sender, EventArgs e)
        {
            // delay the button to .2 seconds
            System.Threading.Thread.Sleep(200);

            // show button
            btnStart.Show();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close this form and open instructions form
            this.Hide();
            var Instructions = new frmInstructions();
            Instructions.Closed += (s, args) => this.Close();
            Instructions.Show();
        }

        // you need a working you win and you lose screen form
        // keeps popping up.
        // also need to track points somehow lol. xD
        // background music and collision sound.
    }
}