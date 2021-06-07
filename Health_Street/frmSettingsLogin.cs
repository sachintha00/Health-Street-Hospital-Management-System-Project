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
    public partial class frmSettingsLogin : Form
    {
        public frmSettingsLogin()
        {
            InitializeComponent();
        }

        private void btnShwPass_Click(object sender, EventArgs e)
        {
        }

        private void btnDiable()
        {
            lblUsername.ForeColor = Color.FromArgb(209, 209, 209);
            txtUsername.BorderColor = Color.FromArgb(209, 209, 209);
            txtUsername.ForeColor = Color.FromArgb(209, 209, 209);
            txtUsername.Enabled = false;
            lblNewPw.ForeColor = Color.FromArgb(209, 209, 209);
            txtNewPassword.BorderColor = Color.FromArgb(209, 209, 209);
            txtNewPassword.ForeColor = Color.FromArgb(209, 209, 209);
            txtNewPassword.Enabled = false;
            lblComPw.ForeColor = Color.FromArgb(209, 209, 209);
            txtCofirmPassword.BorderColor = Color.FromArgb(209, 209, 209);
            txtCofirmPassword.ForeColor = Color.FromArgb(209, 209, 209);
            txtCofirmPassword.Enabled = false;
        }
        private void txtBoxClear()
        {
            txtOldPassword.Clear();
            txtUsername.Clear();
            txtNewPassword.Clear();
            txtCofirmPassword.Clear();
            btnDiable();
        }
        private void frmDctSettingsLogin_Load(object sender, EventArgs e)
        {
            txtOldPassword.Focus();
            btnDiable();
        }

        private void btnShwOldPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtOldPassword.PasswordChar = '\0';
        }

        private void btnShwOldPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtOldPassword.PasswordChar = '●';
        }

        private void btnShwNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
        }

        private void btnShwNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '●';
        }

        private void btnShwComfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtCofirmPassword.PasswordChar = '\0';
        }

        private void btnShwComfirmPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtCofirmPassword.PasswordChar = '●';
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtOldPassword.Text))
            {
                lblOldpassword.ResetText();
                btnDiable();
            }
            else if (txtOldPassword.Text == SQLConnectionManager.getValue("SELECT * FROM ACCOUNT",frmLogin.passingRoll,1,4) )
            {
                lblOldpassword.ResetText();
                txtOldPassword.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                txtOldPassword.BorderColor = Color.DarkGray;
                lblUsername.ForeColor = Color.FromArgb(105, 105, 105);
                txtUsername.BorderColor = Color.DarkGray;
                txtUsername.ForeColor = Color.FromArgb(100, 100, 100);
                txtUsername.Enabled = true;
                lblNewPw.ForeColor = Color.FromArgb(105, 105, 105);
                txtNewPassword.BorderColor = Color.DarkGray;
                txtNewPassword.ForeColor = Color.FromArgb(100, 100, 100);
                txtNewPassword.Enabled = true;
                lblComPw.ForeColor = Color.FromArgb(105, 105, 105);
                txtCofirmPassword.BorderColor = Color.DarkGray;
                txtCofirmPassword.ForeColor = Color.FromArgb(100, 100, 100);
                txtCofirmPassword.Enabled = true;
            }
            else
            {
                lblOldpassword.Text = "*Password is incorrect";
                txtOldPassword.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                btnDiable();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if(txtNewPassword.Text != txtCofirmPassword.Text)
            {
                txtCofirmPassword.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtCofirmPassword.BorderColor = Color.FromArgb(232, 17, 35);
                lblPassword.Text = "*Doesn't match password";
            }
            else if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                lblOldpassword.Text = "*You must enter the old password";
                txtOldPassword.BorderColor = Color.FromArgb(232, 17, 35);
                txtOldPassword.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                btnDiable();
                txtOldPassword.Focus();
            }
            else if(txtOldPassword.Text != SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", frmLogin.passingRoll, 1, 4))
            {
                txtOldPassword.BorderColor = Color.FromArgb(232, 17, 35);
                lblOldpassword.Text = "*Password is incorrect";
                btnDiable();
                txtOldPassword.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtUsername.Text))
                {
                    string sqlcmd1 = "UPDATE ACCOUNT SET Login_Username = '" + txtUsername.Text + "' WHERE Roll_Id = '"+ frmLogin.passingRoll + "'";
                    if (SQLConnectionManager.insrtUpdteDelt(sqlcmd1) == 1)
                    {
                        MessageBox.Show("Successfull");
                    }
                    txtBoxClear();
                }
                if (!string.IsNullOrEmpty(txtCofirmPassword.Text) && !string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    string sqlcmd = "UPDATE ACCOUNT SET Login_Password = '" + txtCofirmPassword.Text + "' WHERE Roll_Id = '" + frmLogin.passingRoll + "'";
                    if (SQLConnectionManager.insrtUpdteDelt(sqlcmd) == 1)
                    {
                        MessageBox.Show("Successfull");
                    }
                    txtBoxClear();
                }

            }
            
        }

        private void txtCofirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtNewPassword.Text == txtCofirmPassword.Text)
            {
                txtCofirmPassword.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                txtCofirmPassword.BorderColor = Color.DarkGray;
                lblPassword.ResetText();
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtCofirmPassword.Text)
            {
                txtCofirmPassword.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                txtCofirmPassword.BorderColor = Color.DarkGray;
                lblPassword.ResetText();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
