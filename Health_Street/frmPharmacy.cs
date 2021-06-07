using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmPharmacy : Form
    {
        clsOpnChild chFrmObj = new clsOpnChild();
        public frmPharmacy()
        {
            InitializeComponent();

            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //phrAnimate.Start();
            pnlCmSubBtn.Visible = false;
            
        }

        private const int CS_Dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_Dropshadow;
                return cp;
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //phrAnimate.Start();
            chFrmObj.openChild(new frmPhrDash(), pnlPhrChild);
        }

        private void subPnlClose()
        {
            if (pnlCmSubBtn.Visible == true)
            {
                pnlCmSubBtn.Visible = false;
                btnSupp.Checked = false;
                btnCus.Checked = false;
                btnOfficer.Checked = false;
            }
        }

        private void btnCmt_Click(object sender, EventArgs e)
        {
            btnCmt.Checked = false;
            if (pnlCmSubBtn.Visible != true)
            {
                btnDashboard.Checked = false;
                btnMed.Checked = false;
                pnlCmSubBtn.Visible = true;
            }
            else
            {
                pnlCmSubBtn.Visible = false;
                btnSupp.Checked = false;
                btnCus.Checked = false;
            }    
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnMed.Checked = false;
            btnOfficer.Checked = false;
            btnSettings.Checked = false;
            chFrmObj.openChild(new frmPhrSplr(), pnlPhrChild);

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnMed.Checked = false;
            btnOfficer.Checked = false;
            btnSettings.Checked = false;
            chFrmObj.openChild(new frmPhrCstmr(), pnlPhrChild);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            subPnlClose();
            chFrmObj.openChild(new frmPhrDash(), pnlPhrChild);
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            chFrmObj.openChild(new frmPhrMdcn(), pnlPhrChild);
            subPnlClose();
        }

        private void btnPchas_Click(object sender, EventArgs e)
        {
            chFrmObj.openChild(new frmOfficer(), pnlPhrChild);
            subPnlClose();
            this.btnOfficer.Checked = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            subPnlClose();
            chFrmObj.openChild(new frmSettings(), pnlPhrChild);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (HSMessageBox.Show("ARE YOU SURE TO EXIT ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.No)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }
    }
}
