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
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Trip tr = new Trip();
            tr.busName = textBox1.Text;
            tr.route = comboBox1.Text;
            tr.category = comboBox2.Text;
            tr.schedual = textBox5.Text;
            tr.rent = textBox4.Text;
            tr.date = dateTimePicker1.Value.Date;
            busticketDataContext up = new busticketDataContext();
            up.Trips.InsertOnSubmit(tr);
            up.SubmitChanges();
            MessageBox.Show("Updated up successfully");
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
