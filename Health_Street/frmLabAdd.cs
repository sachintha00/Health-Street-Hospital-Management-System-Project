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
    public partial class frmLabAdd : Form
    {
        public frmLabAdd(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            txtPatientId.Focus();
            cmbSample.SelectedItem = null;
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

        private void AdNumber()
        {
            txtPatientId.BorderColor = Color.FromArgb(232, 17, 35);
            txtPatientId.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblPatientId.Text = "*cannot be blank";
        }
        private void Sample()
        {
            cmbSample.BorderColor = Color.FromArgb(232, 17, 35);
            cmbSample.FocusedColor = Color.FromArgb(232, 17, 35);
            lblSample.Text = "*cannot be blank";
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
            if(string.IsNullOrEmpty(txtPatientId.Text))
            {
                AdNumber();
                txtPatientId.Focus();
            }
            else if (cmbSample.SelectedIndex == -1)
            {
                Sample();
            }
            else
            {

                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO IN_SAMPLE VALUES('" + txtPatientId.Text+ "','"+cmbSample.Text+"','" + txtWardNo.Text+"','"+txtRoomNo.Text+"','"+dct+"','"+frmLogin.passingRoll+ "',SYSDATETIME(),SYSDATETIME())");

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
            if (!string.IsNullOrEmpty(txtPatientId.Text))
            {
                txtPatientId.BorderColor = Color.Silver;
                txtPatientId.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblPatientId.ResetText();
                if (txtPatientId.Text == SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtPatientId.Text, 2, 2))
                {
                    txtPatientId.BorderColor = Color.Silver;
                    txtPatientId.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                    lblPatientId.ResetText();
                    dct =  SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtPatientId.Text, 2, 8);
                    txtWardNo.Text = SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtPatientId.Text, 2, 9);
                    txtRoomNo.Text = SQLConnectionManager.getValue("SELECT * FROM IN_PATIENT", txtPatientId.Text, 2, 10);
                    txtDctName.Text = SQLConnectionManager.getValue("SELECT * FROM SPECIALIST_DOCTOR", dct, 1, 4);
                }
                else
                {
                    AdNumber();
                    lblPatientId.Text = "*Can't Find";
                    txtWardNo.ResetText();
                    txtRoomNo.ResetText();
                    txtDctName.ResetText();
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
    }
}
