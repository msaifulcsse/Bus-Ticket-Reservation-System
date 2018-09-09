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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                User s = new User();
                s.name = textBox1.Text;
                s.age = textBox2.Text;
                //s.gender = checkBox1.Text;
                //s.gender = checkBox2.Text;
                
                if (checkBox1.Checked)
                {
                    s.gender = "Male";
                }

                if (checkBox2.Checked)
                  { 
                    s.gender = "Female";
                  }
                s.contactno = textBox3.Text;
                s.email = textBox4.Text;
                s.password = textBox5.Text;
                busticketDataContext st = new busticketDataContext();
                st.Users.InsertOnSubmit(s);
                st.SubmitChanges();
                MessageBox.Show("Sign up successfully");
                s.name =" ";
                s.age = " ";
                s.gender = " ";
                s.contactno = " ";
                s.email = " ";
                s.password = " ";
            }
            catch
            {
                MessageBox.Show("Fill up all info ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
