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
    public partial class frmWin2 : Form
    {
        public frmWin2()
        {
            InitializeComponent();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            // close this form and open level 3 screen
            this.Hide();
            var Level3 = new frmLevel3();
            Level3.Closed += (s, args) => this.Close();
            Level3.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // close this form and open level 2 screen
            this.Hide();
            var Level2 = new frmLevel2();
            Level2.Closed += (s, args) => this.Close();
            Level2.Show();
        }
    }
}
