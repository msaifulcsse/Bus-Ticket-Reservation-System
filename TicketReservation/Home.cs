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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool found = false;
            busticketDataContext db = new busticketDataContext();
            string email = textBox1.Text;
            string password = textBox2.Text;
            if (email.Equals("cc") && password.Equals("ccc"))
            {
                this.Hide();
                AdminPanel a = new AdminPanel();
                a.Show();
            }
            else
            {
                foreach (var item in db.Users)
                {
                    if (email.Equals(item.email) && password.Equals(item.password))
                    {
                        MessageBox.Show("You are a member");
                        
                        found = true;
                        ForJourney j = new ForJourney();
                        j.Show();
                        this.Hide();
                        break;
                        
                    }
                }
                if (!found)
                {
                    MessageBox.Show("You are not a member");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }
    }
}
