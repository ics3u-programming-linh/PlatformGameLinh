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
        // upload sound
        //System.Media.SoundPlayer soundPlayer1 = new System.Media.SoundPlayer(@"C:\Users\s272936\Documents\PlatformGameLinh\PlatformGameLinh\Sounds\background.wav");

        public frmSplashScreen()
        {
            InitializeComponent();
            btnStart.Hide();

            // Play the sound
            //soundPlayer1.Play();

            // Loop sound
            //soundPlayer1.PlayLooping();
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
            // close this form and open main menu
            this.Hide();
            var MainMenu = new frmMainMenu();
            MainMenu.Closed += (s, args) => this.Close();
            MainMenu.Show();
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

        // only problem is that when coin collides with coin, plays sound, but the other background music stops working. 
    }
}
