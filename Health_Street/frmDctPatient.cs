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
    public partial class frmDctPatient : Form
    {

        //public static int patientCount;
        public frmDctPatient()
        {
            InitializeComponent();

            for(int i=1; i<=7; i++)
            {
                dgvPatient.Columns[i].ReadOnly = true;
            }

            shoData();
        }

        private void shoData()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_PATIENT");
            dgvPatient.AutoGenerateColumns = false;
            dgvPatient.DataSource = dt;
        }

        private void frm_UpdateEventHandler(object sender, frmAddOutPatients.UpdateEvenetArgs args)
        {
            shoData();
        }



        private void frmDctPatient_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM OUT_PATIENT WHERE Guardian_NIC LIKE '"+ txtSearch.text + "%' OR Patient_Name LIKE '"+ txtSearch.text + "%'");
            dgvPatient.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOutPatients frmadd = new frmAddOutPatients(/*this*/);
            frmadd.UpdateEvenetHanler += frm_UpdateEventHandler;

            new Health_Street.frmTranceparentBG(frmadd);
        }

        private void pnlTheme_Paint(object sender, PaintEventArgs e)
        {

        }


        int n, c = 0;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dgr in dgvPatient.Rows)
            {
                if(Convert.ToBoolean(dgr.Cells[0].Value)==true)
                {
                    n = SQLConnectionManager.insrtUpdteDelt("DELETE FROM OUT_PATIENT WHERE Out_Patient_Id_Number = '" + dgr.Cells[1].Value.ToString() + "'");
                    c += 1;
                }
            }
            shoData();
            if (n == 1)
            {
                HSMessageBox.Show(c + " DATA DELETED SUCCESFULL", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void dgvPatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
