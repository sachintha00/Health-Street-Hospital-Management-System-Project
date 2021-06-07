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
    public partial class frmScanRoom : Form
    {
        clsOpnChild chFrmObj = new clsOpnChild();
        public frmScanRoom()
        {
            InitializeComponent();

            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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

        private void subPnlClose()
        {
            if (pnlSubbtn.Visible == true)
            {
                pnlSubbtn.Visible = false;
                btnStaf.Checked = false;
                btnSettings.Checked = false;
                btnInpatient.Checked = false;
                btnOutpatient.Checked = false;
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            chFrmObj.openChild(new frmScannRoomDash(), pnlPhrChild);
        }


        private void btnCmt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnPatient.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnPatient.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            subPnlClose();
            chFrmObj.openChild(new frmScannRoomDash(), pnlPhrChild);
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            btnPatient.Checked = false;
            if (pnlSubbtn.Visible != true)
            {
                btnDashboard.Checked = false;
                btnStaf.Checked = false;
                btnSettings.Checked = false;
                pnlSubbtn.Visible = true;
            }
            else
            {
                pnlSubbtn.Visible = false;
                btnInpatient.Checked = false;
                btnOutpatient.Checked = false;
            }
        }

        private void btnPchas_Click(object sender, EventArgs e)
        {
            subPnlClose();
            this.btnStaf.Checked = true;
            chFrmObj.openChild(new frmOfficer(), pnlPhrChild);
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

        private void btnInpatient_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;
            chFrmObj.openChild(new frmScanInpatient(), pnlPhrChild);
        }

        private void btnOutpatient_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnStaf.Checked = false;
            btnSettings.Checked = false;
            chFrmObj.openChild(new frmScanOutpatient(), pnlPhrChild);
        }
    }
}
