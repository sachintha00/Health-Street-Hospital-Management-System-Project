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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();

            showData();
            for (int i = 1; i <= 12; i++)
            {
                dgvCustomer.Columns[i].ReadOnly = true;
            }
        }
        
        private void frm_UpdateIventHandler(Object sender, frmChanlAdd.UpdateEvenetArgs args)
        {
            showData();
        }
        private void showData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM CUSTOMER");
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = dt;
        }

        private void frmPhrCstmr_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void pnlTheme_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChanlAdd frm = new frmChanlAdd();
            frm.UpdateEvenetHanler += frm_UpdateIventHandler;
            new Health_Street.frmTranceparentBG(frm);
        }

        int n, c = 0;

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvCustomer.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[0].Value) == true)
                {
                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM CUSTOMER WHERE Invoice_Number = '" + dgr.Cells[1].Value.ToString() + "'");
                    c += 1;
                }
            }
            showData();
            if (n == 1)
            {
                HSMessageBox.Show(c + "DATA DELETED SUCCESSFULLY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
