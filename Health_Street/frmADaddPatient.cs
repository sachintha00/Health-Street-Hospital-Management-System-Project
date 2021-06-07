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
    public partial class frmADaddPatient : Form
    {
        public frmADaddPatient(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
            comboBlood();
            comboDoctor();
            comboWard();
            comboRoom();
            txtFirstname.Focus();
            cmbBlood.SelectedItem = null;
            cmbSpecialist.SelectedItem = null;
            cmbWard.SelectedItem = null;
            cmbRoom.SelectedItem = null;
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
            txtFirstname.Focus();
            cmbBlood.SelectedItem = null;
            cmbSpecialist.SelectedItem = null;
            cmbWard.SelectedItem = null;
            cmbRoom.SelectedItem = null;
        }

        private void comboBlood()
        {
            cmbBlood.Items.Add("A RhD positive (A+)");
            cmbBlood.Items.Add("A RhD negative (A-)");
            cmbBlood.Items.Add("B RhD positive (B+)");
            cmbBlood.Items.Add("B RhD negative (B-)");
            cmbBlood.Items.Add("O RhD positive (O+)");
            cmbBlood.Items.Add("O RhD negative (O-)");
            cmbBlood.Items.Add("AB RhD positive (AB+)");
            cmbBlood.Items.Add("AB RhD negative (AB-)");
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

        private void comboWard()
        {
            DataTable dt2 = new DataTable();
            dt2 = SQLConnectionManager.getdata("SELECT Ward_Name FROM WARD");

            foreach (DataRow dr in dt2.Rows)
            {
                cmbWard.Items.Add(dr["Ward_Name"].ToString());
            }
        }

        private void comboRoom()
        {
            DataTable dt3 = new DataTable();
            dt3 = SQLConnectionManager.getdata("SELECT Room_Name FROM ROOM");

            foreach (DataRow dr in dt3.Rows)
            {
                cmbRoom.Items.Add(dr["Room_Name"].ToString());
            }
        }

        private void firstName()
        {
            txtFirstname.BorderColor = Color.FromArgb(232, 17, 35);
            txtFirstname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblFirst.Text = "*cannot be blank";
        }
        private void middleName()
        {
            txtMiddleName.BorderColor = Color.FromArgb(232, 17, 35);
            txtMiddleName.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblMiddle.Text = "*cannot be blank";
        }

        private void surName()
        {
            txtSurname.BorderColor = Color.FromArgb(232, 17, 35);
            txtSurname.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblSurname.Text = "*cannot be blank";
        }

        private void reson()
        {
            txtReson.BorderColor = Color.FromArgb(232, 17, 35);
            txtReson.FocusedBorderColor = Color.FromArgb(232, 17, 35);
            lblReson.Text = "*cannot be blank";
        }

        private void dof()
        {
            dtpDOF.BorderColor = Color.FromArgb(232, 17, 35);
            dtpDOF.FocusedColor = Color.FromArgb(232, 17, 35);
            lblDOF.Text = "*error";
        }

        private void bloodGroup()
        {
            cmbBlood.BorderColor = Color.FromArgb(232, 17, 35);
            cmbBlood.FocusedColor = Color.FromArgb(232, 17, 35);
            lblBlood.Text = "*cannot be blank";
        }

        private void specialist()
        {
            cmbSpecialist.BorderColor = Color.FromArgb(232, 17, 35);
            cmbSpecialist.FocusedColor = Color.FromArgb(232, 17, 35);
            lblSpecialist.Text = "*cannot be blank";
        }

        private void ward()
        {
            cmbWard.BorderColor = Color.FromArgb(232, 17, 35);
            cmbWard.FocusedColor = Color.FromArgb(232, 17, 35);
            lblWard.Text = "*cannot be blank";
        }

        private void room()
        {
            cmbRoom.BorderColor = Color.FromArgb(232, 17, 35);
            cmbRoom.FocusedColor = Color.FromArgb(232, 17, 35);
            lblRoom.Text = "*cannot be blank";
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
            if(string.IsNullOrEmpty(txtFirstname.Text) && string.IsNullOrEmpty(txtReson.Text) && string.IsNullOrEmpty(txtSurname.Text) && (DateTime.Now.Year == dtpDOF.Value.Year) && (!rdBtnM.Checked && !rdBtnF.Checked) && (cmbBlood.SelectedIndex == -1) && (cmbSpecialist.SelectedIndex == -1) && (cmbWard.SelectedIndex == -1) && (cmbRoom.SelectedIndex == -1) && string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtNic.Text) && string.IsNullOrEmpty(txtAddress.Text) && string.IsNullOrEmpty(txtTpNumber.Text) && string.IsNullOrEmpty(txtRelationship.Text))
            {
                firstName();
                middleName();
                surName();
                reson();
                dof();
                lblGender.Text = "*connot be null";
                bloodGroup();
                specialist();
                ward();
                room();
                name();
                nic();
                tpNumber();
                address();
                relation();
                txtFirstname.Focus();
            }
            else if (txtFirstname.Text.Any(char.IsDigit))
            {
                firstName();
                lblFirst.Text = "*cannot have number";
                txtFirstname.Focus();
            }
            else if (txtMiddleName.Text.Any(char.IsDigit))
            {
                middleName();
                lblMiddle.Text = "*cannot have number";
                txtMiddleName.Focus();
            }
            else if (txtSurname.Text.Any(char.IsDigit))
            {
                surName();
                lblSurname.Text = "*cannot have number";
                txtSurname.Focus();
            }
            else if (txtSurname.Text.Any(char.IsDigit))
            {
                reson();
                lblSurname.Text = "*cannot have number";
                txtReson.Focus();
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
            else if(string.IsNullOrEmpty(txtFirstname.Text))
            {
                firstName();
                txtFirstname.Focus();
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                surName();
                txtSurname.Focus();
            }
            else if (DateTime.Now.Year == dtpDOF.Value.Year)
            {
                dof();
                dtpDOF.Focus();
            }
            else if(string.IsNullOrEmpty(txtReson.Text))
            {
                reson();
                txtReson.Focus();
            }
            else if ((!rdBtnM.Checked && !rdBtnF.Checked))
            {
                lblGender.Text = "*cannot be null";
            }
            else if (cmbBlood.SelectedIndex == -1)
            {
                bloodGroup();
                cmbBlood.Focus();
            }
            else if (cmbSpecialist.SelectedIndex == -1)
            {
                specialist();
                cmbSpecialist.Focus();
            }
            else if (cmbWard.SelectedIndex == -1)
            {
                ward();
                cmbWard.Focus();
            }
            else if (cmbRoom.SelectedIndex == -1)
            {
                room();
                cmbRoom.Focus();
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


                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO GUARDIAN VALUES ('" + txtNic.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtTpNumber.Text + "','" + txtRelationship.Text + "','" + addmitionOffId + "','B0002')");
                string guardianId = SQLConnectionManager.getValue("SELECT * FROM GUARDIAN", txtNic.Text, 2, 1);
                int j = SQLConnectionManager.insrtUpdteDelt("INSERT INTO PATIENT_PRIVATE_DETAIL VALUES ('" + txtFirstname.Text + "','" + txtMiddleName.Text + "','" + txtSurname.Text + "','" + gender + "','" + dtpDOF.Value.ToString("MM-dd-yyy") + "','" + age + "','" + cmbBlood.Text.ToString() + "','" + guardianId + "','" + specialD + "')");

                if (i == 1 && j == 1)
                {
                    HSMessageBox.Show("DATA ADDED SUCCESSFULLY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("DATA ADDED UNSUCCESSFULLY", "ERROR");
                }
                insert();


            }
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtFirstname.Text) && !txtFirstname.Text.Any(char.IsDigit))
            {
                txtFirstname.BorderColor = Color.Silver;
                txtFirstname.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblFirst.ResetText();
            }
            else
            {
                firstName();
                lblFirst.Text = "*cannot have number";
                txtFirstname.Focus();
            }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMiddleName.Text) && !txtMiddleName.Text.Any(char.IsDigit))
            {
                txtMiddleName.BorderColor = Color.Silver;
                txtMiddleName.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblMiddle.ResetText();
            }
            else
            {
                middleName();
                lblMiddle.Text = "*cannot have number";
                txtMiddleName.Focus();
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSurname.Text) && !txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.BorderColor = Color.Silver;
                txtSurname.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblSurname.ResetText();
            }
            else
            {
                surName();
                lblSurname.Text = "*cannot have number";
                txtSurname.Focus();
            }
        }

        string age;
        private void dtpDOF_ValueChanged(object sender, EventArgs e)
        {
            if (!(DateTime.Now.Date == dtpDOF.Value.Date || DateTime.Now.Date < dtpDOF.Value.Date))
            {
                age = Convert.ToString(DateTime.Now.Year - dtpDOF.Value.Year);
                dtpDOF.BorderColor = Color.Silver;
                dtpDOF.FocusedColor = Color.FromArgb(33, 96, 104);
                lblDOF.ResetText();
            }
            else 
            {
                dof();
                dtpDOF.Focus();
            }
        }

        string gender = string.Empty;
        private void rdBtnM_CheckedChanged(object sender, EventArgs e)
        {
            gender = "MALE";
            if (rdBtnM.Checked)
            {
                lblGender.ResetText();
            }
        }

        private void rdBtnF_CheckedChanged(object sender, EventArgs e)
        {
            gender = "FEMALE";
            if (rdBtnF.Checked)
            {
                lblGender.ResetText();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReson_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReson.Text) && !txtReson.Text.Any(char.IsDigit))
            {
                txtReson.BorderColor = Color.Silver;
                txtReson.FocusedBorderColor = Color.FromArgb(33, 96, 104);
                lblReson.ResetText();
            }
            else
            {
                reson();
                lblReson.Text = "*cannot have number";
                txtReson.Focus();
            }
        }

        string specialD = string.Empty;

        private void cmbBlood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(cmbBlood.SelectedIndex == -1))
            {
                cmbBlood.BorderColor = Color.Silver;
                cmbBlood.FocusedColor = Color.FromArgb(33, 96, 104);
                lblBlood.ResetText();
            }
            else
            {
                bloodGroup();
                cmbBlood.Focus();
            }
        }

        private void cmbSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM SPECIALIST_DOCTOR");

            if (!(cmbSpecialist.SelectedIndex == -1))
            {
                foreach (DataRow dr in dt.Rows)
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

        string wardNum = string.Empty;
        private void cmbWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbWard.SelectedIndex == -1))
            {
                if (cmbWard.SelectedIndex == 0)
                {
                    wardNum = "W01";
                }
                else if (cmbWard.SelectedIndex == 1)
                {
                    wardNum = "W02";
                }
                else if (cmbWard.SelectedIndex == 2)
                {
                    wardNum = "W03";
                }
                else if (cmbWard.SelectedIndex == 3)
                {
                    wardNum = "W04";
                }
                cmbWard.BorderColor = Color.Silver;
                cmbWard.FocusedColor = Color.FromArgb(33, 96, 104);
                lblWard.ResetText();
            }
            else
            {
                ward();
                cmbWard.Focus();
            }

            
        }

        string roomNum = string.Empty;
        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbRoom.SelectedIndex == -1))
            {
                if (cmbRoom.SelectedIndex == 0)
                {
                    roomNum = "R001";
                }
                else if (cmbRoom.SelectedIndex == 1)
                {
                    roomNum = "R002";
                }
                else if (cmbRoom.SelectedIndex == 2)
                {
                    roomNum = "R003";
                }
                else if (cmbRoom.SelectedIndex == 3)
                {
                    roomNum = "R004";
                }
                else if (cmbRoom.SelectedIndex == 4)
                {
                    roomNum = "R005";
                }
                else if (cmbRoom.SelectedIndex == 5)
                {
                    roomNum = "R006";
                }
                cmbRoom.BorderColor = Color.Silver;
                cmbRoom.FocusedColor = Color.FromArgb(33, 96, 104);
                lblRoom.ResetText();
            }
            else
            {
                room();
                cmbRoom.Focus();
            }

            
        }
        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNic.Text))
            {
                nic();
                txtNic.Focus();
            }
            else if (!((txtNic.Text.Count(char.IsDigit) == 9) && (txtNic.Text.EndsWith("v") || txtNic.Text.EndsWith("V")) && (txtNic.Text[2] != '4' && txtNic.Text[2] != '9')))
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
    }
}
