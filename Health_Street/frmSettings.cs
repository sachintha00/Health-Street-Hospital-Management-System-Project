using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI;
using Guna.UI.WinForms;

namespace Health_Street
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        clsOpnChild obj = new clsOpnChild();

        private void btnStngLogin_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            pbIcon.Image = Properties.Resources.password;
            obj.openChild(new frmSettingsLogin(), pnlDctSettingsChild);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            pbIcon.Image = Properties.Resources.account;
            obj.openChild(new frmSettingsAccount(), pnlDctSettingsChild);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            pbIcon.Image = Properties.Resources.ContactUs;
            //obj.openChild(new frmdct(), pnlDctSettingsChild);
        }

        private void frmDctSettings_Load(object sender, EventArgs e)
        {
            pbIcon.Image = Properties.Resources.password;
            obj.openChild(new frmSettingsLogin(), pnlDctSettingsChild);
        }
    }
}
