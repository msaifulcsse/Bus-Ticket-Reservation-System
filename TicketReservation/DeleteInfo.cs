using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class DeleteInfo : Form
    {
        busticketDataContext db = new busticketDataContext();
        public DeleteInfo()
        {
            InitializeComponent();
        }
       
        private void DeleteInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Trips;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[a];
            int Id = Convert.ToInt32(selectedRow.Cells[0].Value);
            var businfo = db.Trips.FirstOrDefault(x => x.id == Id);
            db.Trips.DeleteOnSubmit(businfo);
            db.SubmitChanges();
            MessageBox.Show("Trip Deleted");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully logged out");
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
