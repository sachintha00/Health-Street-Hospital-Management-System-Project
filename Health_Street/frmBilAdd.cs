using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmBilAdd : Form
    {
        public frmBilAdd(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
        }

        public delegate void UpdateDelegate(Object sender, UpdateEvenetArgs args);
        public event UpdateDelegate UpdateEvenetHanlerBill;

        public class UpdateEvenetArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void insert()
        {
            UpdateEvenetArgs args = new UpdateEvenetArgs();
            UpdateEvenetHanlerBill.Invoke(this, args);
        }

        private void frmADAddmitPatient_Load(object sender, EventArgs e)
        {
            Animate.Start();
        }

        private void name()
        {
            txtName.BorderColor = Color.FromArgb(232, 17, 35);
            txtName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblName.Text = "*cannot be blank";
        }

        private void address()
        {
            txtAddress.BorderColor = Color.FromArgb(232, 17, 35);
            txtAddress.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblAddress.Text = "*cannot be blank";
        }

        private void nic()
        {
            txtNic.BorderColor = Color.FromArgb(232, 17, 35);
            txtNic.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblNic.Text = "*cannot be blank";
        }

        private void tpNumber()
        {
            txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
            txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblTPnumber.Text = "*cannot be blank";
        }

        private void relation()
        {
            txtRelationship.BorderColor = Color.FromArgb(232, 17, 35);
            txtRelationship.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblRelationship.Text = "*cannot be blank";
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
            if(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtNic.Text) && string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtTpNumber.Text) && string.IsNullOrEmpty(txtRelationship.Text))
            {
                name();
                nic();
                tpNumber();
                address();
                relation();
            }
            else if (txtName.Text.Any(char.IsDigit))
            {
                name();
                lblName.Text = "*cannot have number";
                txtName.Focus();
            }
            else if (txtRelationship.Text.Any(char.IsDigit))
            {
                relation();
                lblRelationship.Text = "*cannot have number";
                txtRelationship.Focus();
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                name();
                txtName.Focus();
            }
            else if(string.IsNullOrEmpty(txtNic.Text))
            {
                nic();
                txtNic.Focus();
            }
            else if(string.IsNullOrEmpty(txtAddress.Text))
            {
                address();
                txtAddress.Focus();
            }
            else if(string.IsNullOrEmpty(txtTpNumber.Text))
            {
                tpNumber();
                txtTpNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtRelationship.Text))
            {
                relation();
                txtRelationship.Focus();
            }
            else if (!Regex.IsMatch(txtTpNumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                tpNumber();
                lblTPnumber.Text = "TP must have 10 numbers";
                txtTpNumber.Focus();
            }
            else if (!((txtNic.Text.Count(char.IsDigit) == 9) && (txtNic.Text.EndsWith("X") || txtNic.Text.EndsWith("V")) && (txtNic.Text[2] != '4' && txtNic.Text[2] != '9')))
            {
                nic();
                lblNic.Text = "EX: 200015500V";
                txtNic.Focus();
            }
            else
            {
                string addmitionOffId = SQLConnectionManager.getValue("SELECT * FROM ADMISSION_OFFICER", frmLogin.passingRoll,10,1);

                MessageBox.Show(addmitionOffId);


                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO GUARDIAN VALUES ('" + txtNic.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtTpNumber.Text + "','" + txtRelationship.Text + "','" + addmitionOffId + "')");
                
               
                if (i == 1)
                {
                    HSMessageBox.Show("DATA ADDED SUCCESSFULY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("DATA ADDED UNSUCCESSFUL", "DataBindings enter une na");
                }
                insert();


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNic.Text))
            {
                nic();
                txtNic.Focus();
            }
            else if (!((txtNic.Text.Count(char.IsDigit) == 9) && (txtNic.Text.EndsWith("X") || txtNic.Text.EndsWith("V")) && (txtNic.Text[2] != '4' && txtNic.Text[2] != '9')))
            {
                nic();
                lblNic.Text = "EX: 200015500V";
                txtNic.Focus();
            }
            else
            {
                txtNic.BorderColor = Color.Silver;
                txtNic.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblNic.ResetText();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !txtName.Text.Any(char.IsDigit))
            {
                txtName.BorderColor = Color.Silver;
                txtName.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblName.ResetText();
            }
            else
            {
                name();
                lblName.Text = "*cannot have number";
                txtName.Focus();
            }
        }

        private void txtRelationship_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRelationship.Text) && !txtRelationship.Text.Any(char.IsDigit))
            {
                txtRelationship.BorderColor = Color.Silver;
                txtRelationship.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblRelationship.ResetText();
            }
            else
            {
                relation();
                lblRelationship.Text = "*cannot have number";
                txtRelationship.Focus();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                txtAddress.BorderColor = Color.Silver;
                txtAddress.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblAddress.ResetText();
            }
            else
            {
                address();
                lblAddress.Text = "*cannot have blank";
                txtAddress.Focus();
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
                lblTPnumber.Text = "TP must have 10 numbers";
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
