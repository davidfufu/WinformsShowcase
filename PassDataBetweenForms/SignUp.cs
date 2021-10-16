using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassDataBetweenForms
{
    public partial class SignUp : Form
    {
        public static string fName;
        public static string lastName;
        public static string emailAddress;
        public static bool sms;
        public static bool reports;
        public static bool transactions;

        Confirmation c = new Confirmation();


        public SignUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fName = txtFirstNameName.Text;
            lastName = txtLastName.Text;
            emailAddress = txtEmailAddress.Text;

            this.Hide();
            c.Show(); 
        }

 

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                reports = true;
                
            }
            else
            {
                reports = false;
               
            }
        }

        private void chkTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactions.Checked)
            {
                transactions = true;
                lblTransactionMessage.Text = "Service Charges may Apply For Transactions";
            }
            else
            {
                transactions = false;
                lblTransactionMessage.Text = ".....";
            }
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMS.Checked)
            {
                sms = true;
                lblSMSMessage.Text = "Services Charges May Apply";
            }
            else
            {
                sms = false;
                lblSMSMessage.Text = ".....";
            }

        }
    }
}
