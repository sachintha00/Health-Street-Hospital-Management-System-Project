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
    public partial class frmADaddmitPatient : Form
    {
        public frmADaddmitPatient()
        {
            InitializeComponent();

            
            for (int i = 1; i <= 13; i++)
            {
                dgvPatient.Columns[i].ReadOnly = true;
            }
            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM PATIENT_PRIVATE_DETAIL,GUARDIAN WHERE PATIENT_PRIVATE_DETAIL.Guardian_Id_Number = GUARDIAN.Guardian_Id_Number");
            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = dt;
        }

        private void frm_UpdateEventHandler(object sender, frmADaddPatient.UpdateEvenetArgs args)
        {
            showData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmADaddPatient frm = new frmADaddPatient(/*this*/);
            frm.UpdateEvenetHanler += frm_UpdateEventHandler;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void frmADaddmitPatient_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM PATIENT_PRIVATE_DETAIL,GUARDIAN WHERE Admission_Number LIKE '" + txtSearch.text + "%' OR First_Name LIKE '" + txtSearch.text + "%' OR Middle_Name LIKE '" + txtSearch.text + "%'");
            dgvPatient.DataSource = dt;
        }

        private void dgvPatient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPatientDetails frm = new frmPatientDetails();
            frm.lblPname.Text = this.dgvPatient.CurrentRow.Cells[1].Value.ToString();
        }

        

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int n, c = 0;

        private void dgvPatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvPatient.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string GId = SQLConnectionManager.getValue("SELECT * FROM GUARDIAN", dgr.Cells[9].Value.ToString(),2,1);
                    
                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM GUARDIAN WHERE Guardian_Id_Number = '"+GId+"'");
                    c += 1;
                }
            }
            showData();
            if (n == 1)
            {
                HSMessageBox.Show(c + " DATA DELETED SUCCESSFULLY ", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
