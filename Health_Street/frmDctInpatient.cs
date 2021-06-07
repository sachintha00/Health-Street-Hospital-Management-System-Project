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
    public partial class frmDctInpatient : Form
    {

        public static string admitionNumber;
        public frmDctInpatient()
        {
            InitializeComponent();

            for (int i = 1; i <= 14; i++)
            {
                dgvInpatient.Columns[i].ReadOnly = true;
            }

            showData();
        }

        private void frm_UpdateEventHandler(object sender, frmADaddPatient.UpdateEvenetArgs args)
        {
            showData();
        }
        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM PATIENT_PRIVATE_DETAIL,GUARDIAN,IN_PATIENT WHERE PATIENT_PRIVATE_DETAIL.Guardian_Id_Number = GUARDIAN.Guardian_Id_Number AND PATIENT_PRIVATE_DETAIL.Patient_Id_Number=IN_PATIENT.Patient_Id_Number");
            dgvInpatient.AutoGenerateColumns = false;
            dgvInpatient.DataSource = dt;
        }

        private void frmDctGuardian_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvGurdiance_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmPatientDetails frm = new frmPatientDetails();
            admitionNumber = this.dgvInpatient.CurrentRow.Cells[1].Value.ToString();
            frm.lblPname.Text = this.dgvInpatient.CurrentRow.Cells[2].Value.ToString() + " " +
                                this.dgvInpatient.CurrentRow.Cells[3].Value.ToString();
            frm.lblGender.Text = this.dgvInpatient.CurrentRow.Cells[5].Value.ToString();
            frm.lblBloodGroup.Text = this.dgvInpatient.CurrentRow.Cells[6].Value.ToString();
            frm.lblDof.Text = this.dgvInpatient.CurrentRow.Cells[7].Value.ToString();
            frm.lblReason.Text = this.dgvInpatient.CurrentRow.Cells[10].Value.ToString();
            frm.lblWard.Text = this.dgvInpatient.CurrentRow.Cells[9].Value.ToString();
            frm.lblRoom.Text = this.dgvInpatient.CurrentRow.Cells[8].Value.ToString();

            new Health_Street.frmTranceparentBG(frm);
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT,PATIENT_PRIVATE_DETAIL,GUARDIAN WHERE (IN_PATIENT.Admission_Number LIKE '" + txtSearch.text + "%' OR PATIENT_PRIVATE_DETAIL.Patient_First_Name LIKE '" + txtSearch.text + "%' OR PATIENT_PRIVATE_DETAIL.Patient_Middle_Name LIKE '" + txtSearch.text + "%' OR PATIENT_PRIVATE_DETAIL.Patient_Last_Name LIKE '" + txtSearch.text + "%' OR PATIENT_PRIVATE_DETAIL.Blood_Group LIKE '" + txtSearch.text + "%' OR IN_PATIENT.Ward_Number LIKE '" + txtSearch.text + "%' OR IN_PATIENT.Room_Number LIKE '" + txtSearch.text + "%' OR IN_PATIENT.Reason LIKE '" + txtSearch.text + "%') AND (PATIENT_PRIVATE_DETAIL.Guardian_Id_Number = GUARDIAN.Guardian_Id_Number AND PATIENT_PRIVATE_DETAIL.Patient_Id_Number=IN_PATIENT.Patient_Id_Number)");
            dgvInpatient.DataSource = dt;
        }


        int n, c = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmADaddPatient frm = new frmADaddPatient(/*this*/);
            frm.UpdateEvenetHanler += frm_UpdateEventHandler;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void dgvInpatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dgr in dgvInpatient.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM IN_PATIENT WHERE Admission_Number = '" + dgr.Cells[1].Value.ToString() + "'");
                    c += 1;
                }
            }
            showData();
            if (n == 1)
            {
                HSMessageBox.Show(c + "DATA DELETED SUCCEFULLY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
