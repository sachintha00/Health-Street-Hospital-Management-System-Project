using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.IO;

namespace Health_Street
{
    public partial class frmXrayAddOut : Form
    {
        public frmXrayAddOut(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            txtPatientId.Focus();
        }

        public delegate void UpdateDelegate(Object sender, UpdateEvenetArgs args);
        public event UpdateDelegate UpdateEvenetHanler;

        public class UpdateEvenetArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void insert()
        {
            UpdateEvenetArgs args = new UpdateEvenetArgs();
            UpdateEvenetHanler.Invoke(this, args);
        }


        private void IdNumber()
        {
            txtPatientId.BorderColor = Color.FromArgb(232, 17, 35);
            txtPatientId.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblApNumber.Text = "*cannot be blank";
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        [Obsolete]
        private void btnPSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPatientId.Text) && string.IsNullOrEmpty(txtXrayPath.Text))
            {
                IdNumber();
                txtPatientId.Focus();
            }
            else if(!(txtPatientId.Text == SQLConnectionManager.getValue("SELECT * FROM OUT_PATIENT", txtPatientId.Text, 0, 0)))
            {
                IdNumber();
                lblApNumber.Text = "*Can't Find";
            }
            else if(string.IsNullOrEmpty(txtXrayPath.Text))
            {
                IdNumber();
                txtPatientId.Focus();
            }
            else
            {
                byte[] image = null;
                if (flag)
                {

                    FileStream fstream = new FileStream(txtXrayPath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    image = br.ReadBytes((int)fstream.Length);
                }
                else
                {
                    image = null;
                }

                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO OUT_PATIENT_XRAY VALUES('" + txtPatientId.Text + "','@image',SYSDATETIME(),SYSDATETIME())", "@image", image);

                if (i == 1)
                {
                    HSMessageBox.Show("DATA ADDED SUCCESSFULY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("DATA ADDED UNSUCCESSFULL", "ERROR");
                }
                insert();


            }
        }

        private void txtApNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPatientId.Text))
            {
                txtPatientId.BorderColor = Color.Silver;
                txtPatientId.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblApNumber.ResetText();
                if (txtPatientId.Text == SQLConnectionManager.getValue("SELECT * FROM OUT_PATIENT", txtPatientId.Text, 0, 0))
                {
                    txtPatientId.BorderColor = Color.Silver;
                    txtPatientId.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                    lblApNumber.ResetText();
                }
                else
                {
                    IdNumber();
                    lblApNumber.Text = "*Can't Find";
                }
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool flag = false;
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Image";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                pctbXray.Image = new Bitmap(ofd.FileName);
                txtXrayPath.Text = ofd.FileName.ToString();
                pctbXray.ImageLocation = txtXrayPath.Text;
            }
        }

        private void pctbXray_Click(object sender, EventArgs e)
        {

        }
    }
}
