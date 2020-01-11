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
    public partial class frmCredits : Form
    {
        public frmCredits()
        {
            InitializeComponent();
        }

        private void mniBack_Click(object sender, EventArgs e)
        {
            // close this form and open splash scren
            this.Hide();
            var SplashScreen = new frmSplashScreen();
            SplashScreen.Closed += (s, args) => this.Close();
            SplashScreen.Show();
        }
    }
}
