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
    public partial class frmPhrSplr : Form
    {
        public frmPhrSplr()
        {
            InitializeComponent();
            for (int i = 1; i <= 7; i++)
            {
                dgvSupplier.Columns[i].ReadOnly = true;
            }
            showData();
        }

        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM DRUG_SUPPLIER,DRUG_ORDER");
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = dt;
        }
        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM DRUG_SUPPLIER,DRUG_ORDER WHERE DRUG_SUPPLIER.Supplier_Id LIKE '" + txtSearch.text + "%' OR DRUG_SUPPLIER.Supplier_Name LIKE '" + txtSearch.text + "%' OR DRUG_SUPPLIER.Manufacture_Company LIKE '" + txtSearch.text + "%' OR DRUG_SUPPLIER.Manufacture_Country LIKE '" + txtSearch.text + "%' OR DRUG_SUPPLIER.Manufacture_Reg_Number LIKE '" + txtSearch.text + "%'");
            dgvSupplier.DataSource = dt;
        }

        private void frmPhrSplr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvSupplier_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frm_insertUpdate(object sender, frmPharSupplierAdd.UpdateEvenetArgs args)
        {
            showData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPharSupplierAdd frm = new frmPharSupplierAdd();
            frm.UpdateEvenetHanler += frm_insertUpdate;
            new Health_Street.frmTranceparentBG(frm);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = 0, c = 0;
            foreach (DataGridViewRow dgr in dgvSupplier.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    string suppId =  dgr.Cells[1].Value.ToString();

                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM DRUG_SUPPLIER WHERE Supplier_Id = '" + suppId + "'");
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
