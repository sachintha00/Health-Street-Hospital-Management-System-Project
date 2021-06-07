using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Health_Street
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            frmChngAnimate.Start();
            txtFirstName.Focus();
        }

        private void firstName()
        {
            txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
            txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblName.Text = "*Cannot be blank first name";
        }
        private void lastName()
        {
            txtLastName.BorderColor = Color.FromArgb(232, 17, 35);
            txtLastName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblSecondName.Text = "*Cannot be blank last name";
        }
        private void gmail()
        {
            txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
            txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblGmail.Text = "*Cannot be blank G-mail";
        }
        private void newPassword()
        {
            txtNewPassword.BorderColor = Color.FromArgb(232, 17, 35);
            txtNewPassword.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblNPassword.Text = "*Cannot be blank Password";
        }
        private void comfirmPassword()
        {
            txtComfirmPassword.BorderColor = Color.FromArgb(232, 17, 35);
            txtComfirmPassword.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblCPassword.Text = "*Cannot be blank Comfirm password";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BorderColor = Color.FromArgb(192, 192, 192);
                txtFirstName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                lblName.ResetText();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                lastName();
                gmail();
                newPassword();
                comfirmPassword();
                txtFirstName.Focus();
            }
            
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                firstName();
                lastName();
                gmail();
                newPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                lastName();
                gmail();
                comfirmPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                gmail();
                newPassword();
                comfirmPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                lastName();
                gmail();
                newPassword();
                comfirmPassword();
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                lastName();
                newPassword();
                comfirmPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text))
            {
                firstName();
                lastName();
                gmail();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                lastName();
                comfirmPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                firstName();
                lastName();
                newPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                firstName();
                gmail();
                newPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                gmail();
                comfirmPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                lastName();
                gmail();
                newPassword();
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                lastName();
                gmail();
                comfirmPassword();
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                gmail();
                newPassword();
                comfirmPassword();
                txtGmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text))
            {
                firstName();
                lastName();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtGmail.Text))
            {
                firstName();
                gmail();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                firstName();
                newPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                firstName();
                comfirmPassword();
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtGmail.Text))
            {
                lastName();
                gmail();
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                lastName();
                newPassword();
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                lastName();
                comfirmPassword();
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtNewPassword.Text))
            {
                gmail();
                newPassword();
                txtGmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtGmail.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                gmail();
                comfirmPassword();
                txtGmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtNewPassword.Text) && string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                newPassword();
                comfirmPassword();
                txtNewPassword.Focus();
            }
            else if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
                txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblGmail.Text = "*Enter a valid email. Ex:name@gmail.com";
                txtGmail.Focus();
            }
            else if (txtNewPassword.Text != txtComfirmPassword.Text)
            {
                txtComfirmPassword.BorderColor = Color.FromArgb(232, 17, 35);
                txtComfirmPassword.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblCPassword.Text = "*Password doesn't match";
                txtComfirmPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtGmail.Text))
            {
                txtGmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtComfirmPassword.Text))
            {
                txtComfirmPassword.Focus();
            }
            else
            {

                int i = SQLConnectionManager.insrtUpdteDelt("UPDATE LOG_IN_USER SET First_Name = '" + txtFirstName.Text + "',Surname = '" + txtLastName.Text + "' WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                int j = SQLConnectionManager.insrtUpdteDelt("UPDATE ACCOUNT SET Login_Password = '"+txtComfirmPassword.Text+"',E_mail='"+txtGmail.Text+ "' WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (i == 1 && j==1)
                {
                    MessageBox.Show("SUCESSFULL");
                }
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.BorderColor = Color.FromArgb(192, 192, 192);
                txtLastName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                lblSecondName.ResetText();
            }
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGmail.Text))
            {
                txtGmail.BorderColor = Color.FromArgb(192, 192, 192);
                txtGmail.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                lblGmail.ResetText();
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.BorderColor = Color.FromArgb(192, 192, 192);
                txtNewPassword.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                lblNPassword.ResetText();
            }
                
        }

        private void txtComfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtComfirmPassword.BorderColor = Color.FromArgb(192, 192, 192);
                txtComfirmPassword.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                lblCPassword.ResetText();
            }
        }
    }
}
