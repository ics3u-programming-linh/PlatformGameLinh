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
    public partial class frmInstructions : Form
    {
        public frmInstructions()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // close this form and open main menu
            this.Hide();
            var MainMenu = new frmMainMenu();
            MainMenu.Closed += (s, args) => this.Close();
            MainMenu.Show();
        }
    }
}
