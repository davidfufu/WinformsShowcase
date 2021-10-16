using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBooking
{
    public partial class FlightBooking : Form
    {

        public static Boolean Passport, IDCard;
        public static String To, From, StartTripDate, EndTripDate, firstName, lastName, documentNumber, IssueDate, ExpiryDate, WeightBaggage;

        private void btnBook_Click(object sender, EventArgs e)
        {
            To = txtTo.Text;
            From = txtFrom.Text;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;

            StartTripDate = monthCalendar1.SelectionStart.ToString("dd MMM yyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MMM yyy");

            documentNumber = txtDocumentNumber.Text;

            IssueDate = dateTimePicker1.Value.ToString("dd MMM yyy");
            ExpiryDate = dateTimePicker2.Value.ToString("dd MMM yyy");

            WeightBaggage = numericUpDown1.Value.ToString();

            this.Hide();
            BookingSummary bs = new BookingSummary();
            bs.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;

            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
        }

        public FlightBooking()
        {
            InitializeComponent();
        }

        private void rdbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPassport.Checked) {
                txtDocument.Text = "Passport Number";
                lblIssueDate.Text = "Passport Issue Date";
                lblExpiryDate.Text = "Passport Expiry Date";
                Passport = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void rdbIDCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIDCard.Checked)
            {
                txtDocument.Text = "ID Card Number";
                lblIssueDate.Text = "ID Card Issue Date";
                lblExpiryDate.Text = "ID Card Expiry Date";
                IDCard = true;
            }
        }
    }
}
