using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmDctMain : Form
    {
        clsOpnChild chld = new clsOpnChild();
        public frmDctMain()
        {
            InitializeComponent();

            if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                SqlDataReader reader1 = SQLConnectionManager.readAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    lblDesignation.Text = reader1[10].ToString();
                    lblsalary.Text = reader1[11].ToString();
                    lblGender.Text = reader1[7].ToString();
                    lblAddress.Text = reader1[5].ToString();
                    lblProfileName.Text = reader1[2].ToString() + " " + reader1[3].ToString();

                    string image = Convert.ToString(reader1[6]);
                    if (image == "System.Byte[]")
                    {
                        MemoryStream mstream = new MemoryStream((byte[])reader1[6]);
                        try
                        {
                            pbProPic.Image = new Bitmap(mstream);
                        }
                        catch (ArgumentException)
                        {
                            pbProPic.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("not Have a picturer");
                        pbProPic.Image = null;
                    }

                }
            }
            if (SQLConnectionManager.chek("SELECT * FROM ACCOUNT WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                SqlDataReader reader2 = SQLConnectionManager.readAndGet("SELECT * FROM ACCOUNT WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader2.Read())
                {
                    lblEmail.Text = reader2[5].ToString();
                }
            }

            dctAnimate.Start();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void PnlScrollOut(Panel pnl)
        {
            pnl.AutoScroll = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmDctMain_Load(object sender, EventArgs e)
        {
            dctAnimate.Start();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            chld.openChild(new frmDctDash(), pnlChildForms);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = true;
            chld.openChild(new frmDctDash(), pnlChildForms);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (HSMessageBox.Show("ARE YOU SURE TO EXIT ?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.No)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void pnlDctmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPatinents_Click_1(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = false;
            chld.openChild(new frmDctPatient(), pnlChildForms);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = false;
            chld.openChild(new frmSettings(), pnlChildForms);
        }

        private void btnGuardian_Click(object sender, EventArgs e)
        {
            pnlRighUserd.Visible = false;
            chld.openChild(new frmDctInpatient(), pnlChildForms);
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
