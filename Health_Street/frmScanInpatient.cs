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
    public partial class frmScanInpatient : Form
    {
        public frmScanInpatient()
        {
            InitializeComponent();
            for (int i = 1; i <= 8; i++)
            {
                dgvInScan.Columns[i].ReadOnly = true;
            }
            showData();
        }

        private void frm_updater(object sender, frmScanAdd.UpdateEvenetArgs args)
        {
            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT_SCAN");
            dgvInScan.AutoGenerateColumns = false;
            dgvInScan.DataSource = dt;
        }

        private void frmPhrCstmr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT_SCAN WHERE In_Patient_Scan_No LIKE '" + txtSearch.text + "%' OR Admission_Number LIKE '" + txtSearch.text + "%' OR Ward_Number LIKE '" + txtSearch.text + "%' OR Room_Number LIKE '" + txtSearch.text + "%' OR Specialist_Doctor_Id LIKE '" + txtSearch.text + "%' ");
            dgvInScan.DataSource = dt;
        }

        private void dgvInScan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmScanAdd frm = new frmScanAdd();
            frm.UpdateEvenetHanler += frm_updater;
            new Health_Street.frmTranceparentBG(frm);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = 0, c = 0;
            foreach (DataGridViewRow dgr in dgvInScan.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string sId = dgr.Cells[1].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM IN_PATIENT_SCAN WHERE In_Patient_Scan_No = '" + sId + "'");
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
