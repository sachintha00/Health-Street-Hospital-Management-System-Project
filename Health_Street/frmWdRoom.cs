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
    public partial class frmWdRoom : Form
    {
        public frmWdRoom()
        {
            InitializeComponent();
            show();
        }

        private void frmWdRoom_Load(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM ROOM, WARD WHERE ROOM.Ward_Number = WARD.Ward_Number");
            dgvRooms.AutoGenerateColumns = false;
            dgvRooms.DataSource = dt;
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SQLConnectionManager.getdata("SELECT * FROM ROOM,WARD WHERE ROOM.Room_Number LIKE '" + txtSearch.text + "%' OR ROOM.Room_Name LIKE '" + txtSearch.text + "%' OR ROOM.Room_Type LIKE '" + txtSearch.text + "%' OR WARD.Ward_Number LIKE '" + txtSearch.text + "%'");
            dgvRooms.DataSource = dt;
        }

        private void dgvRooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
