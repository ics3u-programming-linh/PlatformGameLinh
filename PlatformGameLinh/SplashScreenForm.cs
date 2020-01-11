using System;
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

            // assign url and play music
            wmpBackground.URL = "Sounds/background.mp3";

            // play the music
            wmpBackground.Ctlcontrols.play();

            //loop
            wmpBackground.settings.setMode("loop", true);

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
            // delay the button to .1 seconds
            System.Threading.Thread.Sleep(100);

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

        private void mniCredits_Click(object sender, EventArgs e)
        {
            // close this form and open credits form
            this.Hide();
            var Credits = new frmCredits();
            Credits.Closed += (s, args) => this.Close();
            Credits.Show();
        }

    }
}
