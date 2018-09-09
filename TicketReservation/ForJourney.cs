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
    public partial class ForJourney : Form
    {
        busticketDataContext db = new busticketDataContext();
        static Trip t = new Trip();
        public static Trip return_trip() { return t; }
        public static string seat;
        
        public ForJourney()
        {
            InitializeComponent();
            comboBox1.Items.Add("Dhaka-Khulna");
            comboBox1.Items.Add("Mymensingh-Dhaka");
            comboBox1.Items.Add("Dhaka-Bogra");
            comboBox1.Items.Add("Bogra-Dhaka");
            comboBox1.Items.Add("Dhaka-Jamalpur");
            comboBox1.Items.Add("Jamalpur-Dhaka");

           // comboBox3.Items.Add("A1");
           // comboBox3.Items.Add("A2"); 

            // db.Trips.Select(o => new { })

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully logged out");
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void ForJourney_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var results = from s in db.Trips
                          where s.route == comboBox1.Text
                          && s.date == dateTimePicker1.Value.Date
                          select new
                          {
                              s.id,
                              s.busName,
                              s.category,
                              s.schedual,
                              s.rent
                          };
            dataGridView1.DataSource = results;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForPayment fr = new ForPayment();
            fr.Show();
            this.Hide();

            int a = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[a];
            int idd = Convert.ToInt32(selectedRow.Cells[0].Value);
            Trip trip = new Trip();
            trip = db.Trips.FirstOrDefault(x => x.id == idd);

            if (comboBox3.Text == "A1")
            {

                trip.A1 = "Booked";
                seat = "A1";
                db.SubmitChanges();
            }


            else if (comboBox3.Text == "A2")
            {
                trip.A2 = "Booked";
                seat = "A2";
                db.SubmitChanges();
            }

            else if (comboBox3.Text == "A3")
            {
                trip.A3 = "Booked";
                seat = "A3";
                db.SubmitChanges();
            }

            else if (comboBox3.Text == "A4")
            {
                trip.A4 = "Booked";
                seat = "A4";
                db.SubmitChanges();
            }
            // db.Trips.DeleteOnSubmit(businfo);
            //db.SubmitChanges();
            //Form form = (Form)Application.OpenForms["delete"];



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[a];
            int idd = Convert.ToInt32(selectedRow.Cells[0].Value);
            Trip trip = new Trip();
            trip = db.Trips.FirstOrDefault(x => x.id == idd);


            t = trip;




            if (trip.A1 == null)
            {
                comboBox3.Items.Add("A1");
            }

            if (trip.A2 == null)
            {
                comboBox3.Items.Add("A2");
            }
            if (trip.A3 == null)
            {
                comboBox3.Items.Add("A3");
            }
            if (trip.A4 == null)
            {
                comboBox3.Items.Add("A4");
            }


           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
