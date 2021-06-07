using Microsoft.Reporting.WebForms;
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
    public partial class frmGuardian : Form
    {

        public static string guardianId;
        public frmGuardian()
        {
            InitializeComponent();

            
            for (int i = 1; i <= 8; i++)
            {
                dgvPatient.Columns[i].ReadOnly = true;
            }
            showData();
        }

        private void frm_UpdateEventHandler(object sender, frmBilAdd.UpdateEvenetArgs args)
        {
            showData();
        }
        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM GUARDIAN");
            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //frmBilAdd frm = new frmBilAdd(/*this*/);
            //frm.UpdateEvenetHanlerBill += frm_UpdateEventHandler;
            //new Health_Street.frmTranceparentBG(frm);

            new Reports.frmPrintBillPatient().Show();
        }

        private void frmADaddmitPatient_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM GUARDIAN WHERE Guardian_Id_Number LIKE '" + txtSearch.text + "%' OR Guardian_Name LIKE '" + txtSearch.text + "%' OR Guardian_Address LIKE '" + txtSearch.text + "%' OR Guardian_NIC LIKE '" + txtSearch.text + "%'");
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

        private void dgvPatient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            guardianId = this.dgvPatient.CurrentRow.Cells[1].Value.ToString();
            new Reports.frmPrintBillPatient().ShowDialog();
        }

        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guardianId = this.dgvPatient.CurrentRow.Cells[1].Value.ToString();
            new Reports.frmPrintBillPatient().ShowDialog();
        }

        private void dgvPatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvPatient.Rows)
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
                HSMessageBox.Show(c + "DATA DELETED SUCCESFULL", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
