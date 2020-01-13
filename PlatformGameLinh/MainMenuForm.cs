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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            // disable level 3...
            btnLevel3.Enabled = false;
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

        private void BtnLevel1_Click(object sender, EventArgs e)
        {
            // close this form and open level1
            this.Hide();
            var Level1 = new frmLevel1();
            Level1.Closed += (s, args) => this.Close();
            Level1.Show();
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            // close this form and open level 2
            this.Hide();
            var Level2 = new frmLevel2();
            Level2.Closed += (s, args) => this.Close();
            Level2.Show();
        }
    }
}
