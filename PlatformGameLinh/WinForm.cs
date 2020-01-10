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
    public partial class frmWin : Form
    {

        //lblPoints = "Points:" + points;
        
        public frmWin()
        {
            InitializeComponent();
        }

        private void mniInstructions_Click(object sender, EventArgs e)
        {
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // close this form and open instructions form
            this.Hide();
            var Level1 = new frmLevel1();
            Level1.Closed += (s, args) => this.Close();
            Level1.Show();
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            // close this form and open level 2 screen
            this.Hide();
            var Level2 = new frmLevel2();
            Level2.Closed += (s, args) => this.Close();
            Level2.Show();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // close application
            this.Close();
        }

        private void MniInstructions_Click_1(object sender, EventArgs e)
        {
            // close this form and open instructions form
            this.Hide();
            var Instructions = new frmInstructions();
            Instructions.Closed += (s, args) => this.Close();
            Instructions.Show();
        }
    }
}
