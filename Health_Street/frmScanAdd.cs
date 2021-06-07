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
    public partial class frmScanAdd : Form
    {
        public frmScanAdd(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            txtAdNumber.Focus();
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

        private void adNumber()
        {
            txtAdNumber.BorderColor = Color.FromArgb(232, 17, 35);
            txtAdNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblApNumber.Text = "*cannot be blank";
        }
        private void ScanPath()
        {
            txtXrayPath.BorderColor = Color.FromArgb(232, 17, 35);
            txtXrayPath.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtXrayPath.Text = "*cannot be blank";
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
            if (string.IsNullOrEmpty(txtAdNumber.Text))
            {
                adNumber();
                txtAdNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtXrayPath.Text))
            {
                ScanPath();
                lblScanPath.Text = "*cannot be blank";
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

                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO IN_PATIENT_SCAN VALUES('" + txtAdNumber.Text + "','@image',SYSDATETIME(),SYSDATETIME(),'" + txtWardNo.Text + "','" + txtRoomNo.Text + "','" + dct + "')", "@image", image);

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

        string dct;
        private void txtApNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdNumber.Text))
            {
                txtAdNumber.BorderColor = Color.Silver;
                txtAdNumber.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblApNumber.ResetText();
                if (txtAdNumber.Text == SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtAdNumber.Text, 1, 1))
                {
                    txtAdNumber.BorderColor = Color.Silver;
                    txtAdNumber.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                    lblApNumber.ResetText();
                    dct = txtWardNo.Text = SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtAdNumber.Text, 1, 8);
                    txtWardNo.Text = SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtAdNumber.Text, 1, 9);
                    txtRoomNo.Text = SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtAdNumber.Text, 1, 10);
                    txtDctName.Text = SQLConnectionManager.getValue("SELECT * FROM SPECIALIST_DOCTOR", dct, 1, 4);
                }
                else
                {
                    adNumber();
                    lblApNumber.Text = "*Can't Find";
                    txtDctName.ResetText();
                    txtWardNo.ResetText();
                    txtRoomNo.ResetText();
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
