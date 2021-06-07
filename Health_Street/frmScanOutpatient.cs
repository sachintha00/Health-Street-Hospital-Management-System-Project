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
    public partial class frmScanOutpatient : Form
    {
        public frmScanOutpatient()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)
            {
                dgvOutScan.Columns[i].ReadOnly = true;
            }
            showData();
        }

        private void frm_updateOutScan(object sender, frmScanAddOut.UpdateEvenetArgs args)
        {
            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_PATIENT_SCAN");
            dgvOutScan.AutoGenerateColumns = false;
            dgvOutScan.DataSource = dt;
        }

        private void frmPhrCstmr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_PATIENT_SCAN WHERE Out_Patient_Scan_No LIKE '" + txtSearch.text + "%' OR Patient_Id_Number LIKE '" + txtSearch.text + "%' OR Issue_Date LIKE '" + txtSearch.text + "%' OR Specialist_Doctor_Id LIKE '" + txtSearch.text + "%'");
            dgvOutScan.DataSource = dt;
        }

        private void dgvOutScan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmScanAddOut frm = new frmScanAddOut();
            frm.UpdateEvenetHanler += frm_updateOutScan;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = 0, c = 0;
            foreach (DataGridViewRow dgr in dgvOutScan.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string sId = dgr.Cells[1].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM OUT_PATIENT_SCAN WHERE Out_Patient_Scan_No = '" + sId + "'");
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
