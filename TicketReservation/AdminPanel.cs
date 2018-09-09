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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfo upin = new UpdateInfo();
            upin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteInfo dein = new DeleteInfo();
            dein.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully logged out");
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
