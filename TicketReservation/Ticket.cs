using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Testing
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ForJourney fj = new ForJourney();
            fj.Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pwri = PdfWriter.GetInstance(doc, new FileStream("ticket.pdf", FileMode.Create));
            doc.Open();

         

            Paragraph paragraph = new Paragraph("Bus name: " + textBox5.Text + "                       Bus category: " + textBox6.Text + "\n\nroute: " + textBox7.Text + "                   Dept. time: " + textBox8.Text+ "\n\nseat no: " + ForJourney.seat);
            doc.Add(paragraph);
            doc.Close();
            MessageBox.Show("Your Ticket is Printed as PDF And Thank you very Much");

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            Trip trip = new Trip();
            trip = ForJourney.return_trip();

            textBox5.Text = trip.busName;
            textBox6.Text = trip.category;
            textBox7.Text = trip.route;
            textBox8.Text = trip.schedual;

            textBox9.Text = ForJourney.seat;
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully logged out");
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
