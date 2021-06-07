using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Data;

namespace Health_Street
{
    public partial class frmSettingsAccountEdit : Form
    {
        public static Image ProfilePic;
        public frmSettingsAccountEdit()
        {
            InitializeComponent();

            if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                SqlDataReader reader1 = SQLConnectionManager.readAndGet("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader1.Read())
                {
                    txtFirstName.Text = reader1["First_Name"].ToString();
                    txtMiddleName.Text = reader1["Middle_Name"].ToString();
                    txtSurname.Text = reader1["Surname"].ToString();
                    txtAddress.Text = reader1["User_Address"].ToString();
                    txtTpNumber.Text = reader1["User_Tele_No"].ToString();
                    txtDesignation.Text = reader1["Designation"].ToString();
                    txtSalary.Text = reader1["Salary"].ToString();

                    string image = Convert.ToString(reader1[6]);
                    if (image == "System.Byte[]")
                    {
                        MemoryStream mstream = new MemoryStream((byte[])reader1[6]);
                        try
                        {
                            pbProfile.Image = new Bitmap(mstream);
                        }
                        catch (ArgumentException)
                        {
                            pbProfile.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("not Have a picturer");
                        pbProfile.Image = null;
                    }

                }
            }

            if (SQLConnectionManager.chek("SELECT * FROM ACCOUNT WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 1)
            {
                SqlDataReader reader2 = SQLConnectionManager.readAndGet("SELECT * FROM ACCOUNT WHERE Roll_Id = '" + frmLogin.passingRoll + "'");
                if (reader2.Read())
                {
                    txtGmail.Text = reader2["E_mail"].ToString();
                }
            }
        }

        private void frmDctSettingsAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void firstName()
        {
            txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
            lblFirstName.Text = "*First name cannot be blank";
        }
        private void surName()
        {
            txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
            lblSurname.Text = "*Surname cannot be blank";
        }
        private void dateOfBirth()
        {
            dtpDateofBirth.OnHoverBorderColor = Color.FromArgb(232, 17, 35);
            dtpDateofBirth.BorderColor = Color.FromArgb(232, 17, 35);
            dtpDateofBirth.ForeColor = Color.FromArgb(232, 17, 35);
            dtpDateofBirth.FocusedColor = Color.FromArgb(232, 17, 35);
            lblDateTime.Text = "*Cannot be blank";
        }
        private void tpNumber()
        {
            txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
            lblTp.Text = "TP number cannot be blank";
        }
        private void address()
        {
            txtAddress.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtAddress.BorderColor = Color.FromArgb(232, 17, 35);
            lblAddress.Text = "Address cannot be blank";
        }
        private void gmail()
        {
            txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
            lblGmail.Text = "Gmail canot be blank";
        }
        private void designation()
        {
            txtDesignation.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtDesignation.BorderColor = Color.FromArgb(232, 17, 35);
            lblDesignation.Text = "Designation cannot be blank";
        }

        private void salary()
        {
            txtSalary.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            txtSalary.BorderColor = Color.FromArgb(232, 17, 35);
            lblSalary.Text = "Salary Cannot be blank";
        }

        public delegate void UpdateDelegate(object sender, UpdatedEventArgs arg);
        public event UpdateDelegate updateEvent;

        public class UpdatedEventArgs : EventArgs
        {
            public string data
            {
                get;
                set;
            }
        }

        private void insert()
        {
            UpdatedEventArgs args = new UpdatedEventArgs();
            updateEvent.Invoke(this, args);
        }

        [Obsolete]
        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year == dtpDateofBirth.Value.Year))
            {
                dateOfBirth();
                dtpDateofBirth.Focus();
            }
            else if (DateTime.Now.Year <= dtpDateofBirth.Value.Year)
            {
                dtpDateofBirth.OnHoverBorderColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.BorderColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.ForeColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.FocusedColor = Color.FromArgb(232, 17, 35);
                lblDateTime.Text = "*cant";
            }
            else if (txtFirstName.Text.Any(char.IsDigit))
            {
                txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
                lblFirstName.Text = "cannot have numbers";
            }
            else if (txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
                lblSurname.Text = "cannot have numbers";
            }
            else if (txtMiddleName.Text.Any(char.IsDigit))
            {
                txtMiddleName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtMiddleName.BorderColor = Color.FromArgb(232, 17, 35);
                lblMiddleName.Text = "cannot have numbers";
            }
            else if (!Regex.IsMatch(txtTpNumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
                lblTp.Text = "TP must have 10 numbers";
            }
            else if (txtAddress.Text.Any(char.IsDigit))
            {
                txtAddress.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtAddress.BorderColor = Color.FromArgb(232, 17, 35);
                lblAddress.Text = "cannot have numbers";
            }
            else if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
                lblGmail.Text = "Enter a valid email. Ex:name@gmail.com";
            }
            else if (txtDesignation.Text.Any(char.IsDigit))
            {
                txtDesignation.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtDesignation.BorderColor = Color.FromArgb(232, 17, 35);
                lblDesignation.Text = "cannot have numbers";
            }
            else if (!txtSalary.Text.Any(char.IsDigit))
            {
                txtSalary.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSalary.BorderColor = Color.FromArgb(232, 17, 35);
                lblSalary.Text = "cannot have String";
            }
            else
            {
                byte[] image = null;
                if (flag)
                {
                    
                    FileStream fstream = new FileStream(imgeLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    image = br.ReadBytes((int)fstream.Length);
                }
                else
                {
                    image = null;
                }


                if (SQLConnectionManager.chek("SELECT * FROM LOG_IN_USER WHERE Roll_Id = '" + frmLogin.passingRoll + "'") == 0)
                {

                    int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO LOG_IN_USER VALUES ('" + frmLogin.passingRoll + "','" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtSurname.Text + "','" + txtAddress.Text + "',@image,'" + gender + "','" + txtTpNumber.Text + "','" + dof + "','" + txtDesignation.Text + "','" + txtSalary.Text + "')", "@image", image);
                    int j = SQLConnectionManager.insrtUpdteDelt("UPDATE ACCOUNT SET E_mail = '" + txtGmail.Text + "' WHERE Roll_Id = '" + frmLogin.passingRoll + "'");

                    if (i == 1 && j == 1)
                    {
                        HSMessageBox.Show("DATA ADDED SUCCESFULL","SUCCESFULL",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        HSMessageBox.Show("DATA ADDED UNSUCCESSFULL", "UNSUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    int j = SQLConnectionManager.insrtUpdteDelt("UPDATE LOG_IN_USER SET First_Name='"+ txtFirstName.Text + "',Middle_Name='"+ txtMiddleName.Text + "',Surname='"+ txtSurname.Text + "',User_Address='"+ txtAddress.Text + "',Img=@image, Gender='" + gender + "', User_Tele_No='"+ txtTpNumber.Text + "', Date_Of_Birth='"+ dof + "', Designation='"+ txtDesignation.Text + "', Salary='"+ txtSalary.Text + "' WHERE Roll_Id='"+frmLogin.passingRoll+"'", "@image", image);
                    int i = SQLConnectionManager.insrtUpdteDelt("UPDATE ACCOUNT SET E_mail = '" + txtGmail.Text + "' WHERE Roll_Id = '" + frmLogin.passingRoll + "'");

                    if (i == 1 && j == 1)
                    {
                        HSMessageBox.Show("DATA UPPDATED SUCCESFULL","SUCCESFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        HSMessageBox.Show("DATA UPPDATED UNSUCCESSFULL", "UNSUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    insert();

                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !txtFirstName.Text.Any(char.IsDigit))
            {
                txtFirstName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtFirstName.BorderColor = Color.Silver;
                lblFirstName.ResetText();
            }
            else if (txtFirstName.Text.Any(char.IsDigit))
            {
                txtFirstName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtFirstName.BorderColor = Color.FromArgb(232, 17, 35);
                lblFirstName.Text = "CAN'T HAVE NUMBERS";
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSurname.Text) && !txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtSurname.BorderColor = Color.Silver;
                lblSurname.ResetText();
            }
            else if (txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
                lblSurname.Text = "CAN'T HAVE NUMBERS";
            }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!txtMiddleName.Text.Any(char.IsDigit))
            {
                txtMiddleName.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtMiddleName.BorderColor = Color.Silver;
                lblMiddleName.ResetText();
            }
            else
            {
                txtMiddleName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtMiddleName.BorderColor = Color.FromArgb(232, 17, 35);
                lblMiddleName.Text = "CAN'T HAVE NUMBERS";
            }
        }

        string dof;
        private void dtpDateofBirth_ValueChanged(object sender, EventArgs e)
        {
            if (!(DateTime.Now.Date == dtpDateofBirth.Value.Date || DateTime.Now.Date < dtpDateofBirth.Value.Date))
            {
                dof = dtpDateofBirth.Value.ToString("MM-dd-yyy");
                dtpDateofBirth.BorderColor = Color.Silver;
                dtpDateofBirth.FocusedColor = Color.FromArgb(33, 96, 104);
                lblDateTime.ResetText();
            }
            else
            {
                dtpDateofBirth.BorderColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.FocusedColor = Color.FromArgb(232, 17, 35);
                dtpDateofBirth.Text = "ERROR";
                dtpDateofBirth.Focus();
            }
        }

        string imgeLocation = string.Empty;
        bool flag = false;
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Image";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                pbProfile.Image = new Bitmap(ofd.FileName);
                imgeLocation = ofd.FileName.ToString();
                pbProfile.ImageLocation = imgeLocation;
            }
        }

        private void txtTpNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTpNumber.Text))
            {
                txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
                txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblTp.Text = "CAN'T BE BLANK";
                txtTpNumber.Focus();
            }
            else if (!Regex.IsMatch(txtTpNumber.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                txtTpNumber.BorderColor = Color.FromArgb(232, 17, 35);
                txtTpNumber.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblTp.Text = "TP MUST HAVE 10 NUMBERS";
                txtTpNumber.Focus();
            }
            else
            {
                txtTpNumber.BorderColor = Color.Silver;
                txtTpNumber.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblTp.ResetText();
            }
        }

        string gender = string.Empty;
        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "FEMALE";
            if(rdoFemale.Checked)
            {
                lblGender.ResetText();
            }
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "MALE";
            if(rdoMale.Checked)
            {
                lblGender.ResetText();
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
                txtAddress.BorderColor = Color.FromArgb(232, 17, 35);
                txtAddress.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblAddress.Text = "CAN'T BE BLANK";
                txtAddress.Focus();
            }
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGmail.Text))
            {
                txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
                txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblGmail.Text = "CAN'T BE BLANK";
                txtGmail.Focus();
            }
            else if (!Regex.IsMatch(txtGmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                txtGmail.BorderColor = Color.FromArgb(232, 17, 35);
                txtGmail.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                lblGmail.Text = "ENTER A VALID EMAIL. Ex:name@gmail.com";
                txtGmail.Focus();
            }
            else
            {
                txtGmail.BorderColor = Color.Silver;
                txtGmail.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblGmail.ResetText();
            }
        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDesignation.Text) && !txtDesignation.Text.Any(char.IsDigit))
            {
                txtDesignation.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtDesignation.BorderColor = Color.Silver;
                lblDesignation.ResetText();
            }
            else if (txtDesignation.Text.Any(char.IsDigit))
            {
                txtDesignation.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtDesignation.BorderColor = Color.FromArgb(232, 17, 35);
                lblDesignation.Text = "CAN'T BE NUMBERS";
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalary.Text) && txtSalary.Text.Any(char.IsDigit))
            {
                txtSalary.FocusedBorderColor = Color.FromArgb(50, 144, 156);
                txtSalary.BorderColor = Color.Silver;
                lblSalary.ResetText();
            }
            else if (!txtSalary.Text.Any(char.IsDigit))
            {
                txtSalary.FocusedBorderColor = Color.FromArgb(232, 17, 35);
                txtSalary.BorderColor = Color.FromArgb(232, 17, 35);
                lblSalary.Text = "CAN'T HAVE STRINGS";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new Health_Street.frmTranceparentBG(new frmSettingsAccountEdit());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
