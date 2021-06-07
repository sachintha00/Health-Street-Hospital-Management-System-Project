using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Automation.Peers;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmAddOutPatients : Form
    {
        public frmAddOutPatients(/*Form frmOut*/)
        {
            InitializeComponent();
        }


        public delegate void UpdateDelegate(object sender, UpdateEvenetArgs args);
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
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            frmChngAnimate.Start();
            txtPatientName.Focus();
        }

        private void patientName()
        {
            txtPatientName.BorderColor = Color.FromArgb(232, 17, 35);
            txtPatientName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblName.Text = "*Cannot be blank first name";
        }
        private void guardianNic()
        {
            txtGuardianNic.BorderColor = Color.FromArgb(232, 17, 35);
            txtGuardianNic.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblGuardianNic.Text = "*Cannot be blank last name";
        }
        private void guardianTp()
        {
            txtGuardianTP.BorderColor = Color.FromArgb(232, 17, 35);
            txtGuardianTP.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblTPNumber.Text = "*Cannot be blank G-mail";
        }
        private void age()
        {
            txtAge.BorderColor = Color.FromArgb(232, 17, 35);
            txtAge.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblAge.Text = "*Cannot be blank Password";
        }
        private void reason()
        {
            txtReason.BorderColor = Color.FromArgb(232, 17, 35);
            txtReason.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblReason.Text = "*Cannot be blank Comfirm password";
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPatientName.Text) && !txtPatientName.Text.Any(char.IsDigit))
            {
                txtPatientName.BorderColor = Color.Silver;
                txtPatientName.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblName.ResetText();
            }
            else
            {
                patientName();
                lblName.Text = "*cannot have number";
                txtPatientName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientName.Text) && string.IsNullOrEmpty(txtGuardianNic.Text) && string.IsNullOrEmpty(txtGuardianTP.Text) && string.IsNullOrEmpty(txtGuardianTP.Text) && string.IsNullOrEmpty(txtAge.Text) && string.IsNullOrEmpty(txtReason.Text))
            {
                patientName();
                guardianNic();
                guardianTp();
                age();
                reason();
                txtPatientName.Focus();
            }
            else if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                patientName();
            }
            else if (string.IsNullOrEmpty(txtGuardianNic.Text))
            {
                guardianNic();
            }
            else if (string.IsNullOrEmpty(txtGuardianTP.Text))
            {
                guardianTp();
            }
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                age();
            }
            else if (string.IsNullOrEmpty(txtReason.Text))
            {
                reason();
            }
            else if (txtPatientName.Text.Any(char.IsDigit))
            {
                patientName();
                lblName.Text = "cannot inset digit";
            }
            else if (!((txtGuardianNic.Text.Count(char.IsDigit) == 9) && (txtGuardianNic.Text.EndsWith("X") || txtGuardianNic.Text.EndsWith("V")) && (txtGuardianNic.Text[2] != '4' && txtGuardianNic.Text[2] != '9')))
            {
                patientName();
                lblGuardianNic.Text = "EX: 200015500V";
            }
            else if (!Regex.IsMatch(txtGuardianTP.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                guardianTp();
                lblTPNumber.Text = "TP must have 10 numbers";
            }
            else if (!txtAge.Text.Any(char.IsDigit))
            {
                age();
                lblAge.Text = "cannot inset string";
            }
            else if (txtReason.Text.Any(char.IsDigit))
            {
                reason();
                lblReason.Text = "cannot inset digit";
            }
            else
            {
                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO OUT_PATIENT VALUES ('" + txtPatientName.Text + "','" + txtGuardianNic.Text + "','" + txtGuardianTP.Text + "','" + txtAge.Text + "','" + txtReason.Text + "',SYSDATETIME(), SYSDATETIME())");
                if (i == 1)
                {
                    MessageBox.Show("SUCCESSFULL");
                }
                insert();
            }

        }

        private void txtGuardianNic_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuardianNic.Text))
            {
                guardianNic();
                txtGuardianNic.Focus();
            }
            else if (!((txtGuardianNic.Text.Count(char.IsDigit) == 9) && (txtGuardianNic.Text.EndsWith("X") || txtGuardianNic.Text.EndsWith("V")) && (txtGuardianNic.Text[2] != '4' && txtGuardianNic.Text[2] != '9')))
            {
                guardianNic();
                lblGuardianNic.Text = "EX: 200015500V";
                txtGuardianNic.Focus();
            }
            else
            {
                txtGuardianNic.BorderColor = Color.Silver;
                txtGuardianNic.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblGuardianNic.ResetText();
            }
        }

        private void txtGuardianTP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuardianTP.Text))
            {
                guardianTp();
                txtGuardianTP.Focus();
            }
            else if (!Regex.IsMatch(txtGuardianTP.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                guardianTp();
                lblTPNumber.Text = "TP must have 10 numbers";
                txtGuardianTP.Focus();
            }
            else
            {
                txtGuardianTP.BorderColor = Color.Silver;
                txtGuardianTP.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblTPNumber.ResetText();
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAge.Text) && txtAge.Text.Any(char.IsDigit))
            {
                txtAge.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtAge.BorderColor = Color.Silver;
                lblAge.ResetText();
            }
            else if (!txtAge.Text.Any(char.IsDigit))
            {
                txtAge.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtAge.BorderColor = Color.FromArgb(232, 17, 35);
                lblAge.Text = "cannot have String";
            }

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReason.Text) && !txtReason.Text.Any(char.IsDigit))
            {
                txtReason.BorderColor = Color.Silver;
                txtReason.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblReason.ResetText();
            }
            else
            {
                reason();
                lblReason.Text = "*cannot have number";
                txtReason.Focus();
            }
        }
    }
}
