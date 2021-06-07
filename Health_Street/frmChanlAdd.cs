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

namespace Health_Street
{
    public partial class frmChanlAdd : Form
    {
        public frmChanlAdd(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            comboDoctor();
            txtApNumber.Focus();
            cmbSpecialist.SelectedItem = null;
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

        private void frmADAddmitPatient_Load(object sender, EventArgs e)
        {
            Animate.Start();
            txtApNumber.Focus();
            cmbSpecialist.SelectedItem = null;
        }

        private void comboDoctor()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT S_Doctor_Name FROM SPECIALIST_DOCTOR");

            foreach(DataRow dr in dt.Rows)
            {
                cmbSpecialist.Items.Add(dr["S_Doctor_Name"].ToString());
            }
        }

        private void ApNumber()
        {
            txtApNumber.BorderColor = Color.FromArgb(232, 17, 35);
            txtApNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblApNumber.Text = "*Cannot be blank";
        }

        private void surName()
        {
            txtPatientName.BorderColor = Color.FromArgb(232, 17, 35);
            txtPatientName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblPatientName.Text = "*Cannot be blank";
        }

        private void dof()
        {
            dtpSessionDate.BorderColor = Color.FromArgb(232, 17, 35);
            dtpSessionDate.FocusedColor = Color.FromArgb(232, 17, 35);
            lblSessionDate.Text = "*Cannot be blank";
        }

        private void specialist()
        {
            cmbSpecialist.BorderColor = Color.FromArgb(232, 17, 35);
            cmbSpecialist.FocusedColor = Color.FromArgb(232, 17, 35);
            lblSpecialist.Text = "*Cannot be blank";
        }

        private void dctFee()
        {
            txtDctFee.BorderColor = Color.FromArgb(232, 17, 35);
            txtDctFee.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblDctFee.Text = "*Cannot be blank";
        }

        private void hsptlFee()
        {
            txtHsptlFee.BorderColor = Color.FromArgb(232, 17, 35);
            txtHsptlFee.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblHsptlFee.Text = "*Cannot be blank";
        }

        private void tpNumber()
        {
            txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
            txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblTPnumber.Text = "*Cannot be blank";
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
        private void btnPSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtApNumber.Text) && string.IsNullOrEmpty(txtPatientName.Text) && (DateTime.Now.Year == dtpSessionDate.Value.Year) && (cmbSpecialist.SelectedIndex == -1) && string.IsNullOrEmpty(txtDctFee.Text) && string.IsNullOrEmpty(txtHsptlFee.Text) && string.IsNullOrEmpty(txtTpNumber.Text))
            {
                ApNumber();
                surName();
                dof();
                specialist();
                dctFee();
                tpNumber();
                hsptlFee();
                txtApNumber.Focus();
            }
            else if (!txtApNumber.Text.Any(char.IsDigit))
            {
                ApNumber();
                lblApNumber.Text = "*Cannot have String";
                txtApNumber.Focus();
            }
            else if (txtPatientName.Text.Any(char.IsDigit))
            {
                surName();
                lblPatientName.Text = "*Cannot have number";
                txtPatientName.Focus();
            }
            else if (!txtDctFee.Text.Any(char.IsDigit))
            {
                dctFee();
                lblDctFee.Text = "*Cannot have number";
                txtDctFee.Focus();
            }
            else if (!txtHsptlFee.Text.Any(char.IsDigit))
            {
                hsptlFee();
                lblDctFee.Text = "*Cannot have number";
                txtDctFee.Focus();
            }
            else if(string.IsNullOrEmpty(txtApNumber.Text))
            {
                ApNumber();
                txtApNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                surName();
                txtPatientName.Focus();
            }
            else if (DateTime.Now.Year > dtpSessionDate.Value.Year)
            {
                dof();
                dtpSessionDate.Focus();
            }
            else if (cmbSpecialist.SelectedIndex == -1)
            {
                specialist();
                cmbSpecialist.Focus();
            }
            else if (string.IsNullOrEmpty(txtDctFee.Text))
            {
                dctFee();
                txtDctFee.Focus();
            }
            else if(string.IsNullOrEmpty(txtHsptlFee.Text))
            {
                hsptlFee();
                txtHsptlFee.Focus();
            }
            else if(string.IsNullOrEmpty(txtTpNumber.Text))
            {
                tpNumber();
                txtTpNumber.Focus();
            }
            else if (!Regex.IsMatch(txtTpNumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                tpNumber();
                lblTPnumber.Text = "Tele Phone Number Must have 10 numbers";
                txtTpNumber.Focus();
            }
            else
            {

                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO CUSTOMER VALUES('" + txtApNumber.Text+"','"+cmbSpecialist.SelectedItem.ToString()+"','"+specialD+"','"+dtpSessionDate.Value.ToString("MM-dd-yyy")+"','"+txtPatientName.Text+"','"+txtTpNumber.Text+"','"+txtHsptlFee.Text+"','"+txtDctFee.Text+ "',SYSDATETIME(),SYSDATETIME(),'C0001')");

                if (i == 1 /*&& j == 1*/)
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
            if(!string.IsNullOrEmpty(txtApNumber.Text) && txtApNumber.Text.Any(char.IsDigit))
            {
                txtApNumber.BorderColor = Color.Silver;
                txtApNumber.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblApNumber.ResetText();
            }
            else
            {
                ApNumber();
                lblApNumber.Text = "*Cannot have String";
                txtApNumber.Focus();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPatientName.Text) && !txtPatientName.Text.Any(char.IsDigit))
            {
                txtPatientName.BorderColor = Color.Silver;
                txtPatientName.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblPatientName.ResetText();
            }
            else
            {
                surName();
                lblPatientName.Text = "*Cannot have number";
                txtPatientName.Focus();
            }
        }

        string age;
        private void dtpDOF_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Date <= dtpSessionDate.Value.Date )
            {
                dtpSessionDate.BorderColor = Color.Silver;
                dtpSessionDate.FocusedColor = Color.FromArgb(33, 96, 104);
                lblSessionDate.ResetText();
            }
            else 
            {
                dof();
                dtpSessionDate.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string specialD;
        private void cmbSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM SPECIALIST_DOCTOR");

            if (!(cmbSpecialist.SelectedIndex == -1))
            {

                foreach(DataRow dr in dt.Rows)
                {
                    if (cmbSpecialist.SelectedItem.ToString() == dr["S_Doctor_Name"].ToString())
                    {
                        specialD = dr["Specialist_Doctor_Id"].ToString();
                    }
                }
                cmbSpecialist.BorderColor = Color.Silver;
                cmbSpecialist.FocusedColor = Color.FromArgb(33, 96, 104);
                lblSpecialist.ResetText();
            }
            else
            {
                specialist();
                cmbSpecialist.Focus();
            }

            
        }

        private void txtDctFee_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDctFee.Text) && txtDctFee.Text.Any(char.IsDigit))
            {
                txtDctFee.BorderColor = Color.Silver;
                txtDctFee.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblDctFee.ResetText();
            }
            else
            {
                dctFee();
                lblDctFee.Text = "*Cannot have number";
                txtDctFee.Focus();
            }
        }

        private void txtHsptlFee_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHsptlFee.Text) && txtHsptlFee.Text.Any(char.IsDigit))
            {
                txtHsptlFee.BorderColor = Color.Silver;
                txtHsptlFee.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblHsptlFee.ResetText();
            }
            else
            {
                hsptlFee();
                lblHsptlFee.Text = "*Cannot have blank";
                txtHsptlFee.Focus();
            }
        }

        private void txtTpNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTpNumber.Text))
            {
                tpNumber();
                txtTpNumber.Focus();
            }
            else if (!Regex.IsMatch(txtTpNumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                tpNumber();
                lblTPnumber.Text = "Tele Phone Number Must have 10 numbers";
                txtTpNumber.Focus();
            }
            else
            {
                txtTpNumber.BorderColor = Color.Silver;
                txtTpNumber.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblTPnumber.ResetText();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
