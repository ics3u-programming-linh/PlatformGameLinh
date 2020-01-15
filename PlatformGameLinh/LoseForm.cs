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
    public partial class frmLose : Form
    {
        public frmLose()
        {
            InitializeComponent();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            // close this form and open main menu form
            this.Hide();
            var MainMenu = new frmMainMenu();
            MainMenu.Closed += (s, args) => this.Close();
            MainMenu.Show();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void MniInstructions_Click(object sender, EventArgs e)
        {
            // close this form and open instructions form
            this.Hide();
            var Instructions = new frmInstructions();
            Instructions.Closed += (s, args) => this.Close();
            Instructions.Show();
        }
    }
}
