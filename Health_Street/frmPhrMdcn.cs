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
    public partial class frmPhrMdcn : Form
    {
        public frmPhrMdcn()
        {
            InitializeComponent();
            for (int i = 1; i <= 9; i++)
            {
                dgvMedicine.Columns[i].ReadOnly = true;
            }
            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM DRUG");
            dgvMedicine.AutoGenerateColumns = false;
            dgvMedicine.DataSource = dt;
        }

        private void frm_insertUpdate(object sender, frmPhrMedAdd.UpdateEvenetArgs args)
        {
            showData();
        }

        private void frmPhrMdcn_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM PHARMACY_MEDICINES WHERE Pharmacy_Invoice_Number LIKE '" + txtSearch.text + "%' OR Drug_Code LIKE '" + txtSearch.text + "%' OR Quantity LIKE '" + txtSearch.text + "%' OR Number_Of_Days LIKE '" + txtSearch.text + "%'");
            dgvMedicine.AutoGenerateColumns = false;
            dgvMedicine.DataSource = dt;
        }

        private void dgvMedicine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPhrMedAdd frm = new frmPhrMedAdd();
            frm.UpdateEvenetHanler += frm_insertUpdate;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n=0, c = 0;
            foreach (DataGridViewRow dgr in dgvMedicine.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string drugId = dgr.Cells[2].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM DRUG WHERE Drug_Code = '" + drugId + "'");
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
