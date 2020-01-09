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
            // close this form and open instructions form
            this.Hide();
            var Level1 = new frmLevel1();
            Level1.Closed += (s, args) => this.Close();
            Level1.Show();
        }
    }
}
