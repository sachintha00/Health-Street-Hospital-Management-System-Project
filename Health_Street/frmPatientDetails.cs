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
    public partial class frmPatientDetails : Form
    {
        public frmPatientDetails()
        {
            InitializeComponent();
            MessageBox.Show(frmDctInpatient.admitionNumber);
            show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show()
        {
            DataTable dt1 = new DataTable();
            dt1 = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT_REPORT WHERE Admission_Number = '"+frmDctInpatient.admitionNumber+"'");
            dgvReports.AutoGenerateColumns = false;
            dgvReports.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = SQLConnectionManager.getdata("SELECT * FROM IN_PATIENT_MEDICINE WHERE Admission_Number = '" + frmDctInpatient.admitionNumber + "'");
            dgvMedicine.AutoGenerateColumns = false;
            dgvMedicine.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Report.frmRptDctInpatient().Show();
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvInpatient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gunaDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
