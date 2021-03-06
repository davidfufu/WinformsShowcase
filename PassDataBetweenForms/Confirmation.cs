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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFName.Text = SignUp.fName;
            lblLastName.Text = SignUp.lastName;
            lblEmailAddress.Text = SignUp.emailAddress;

            lblSMS.Text = SignUp.sms ? "X" : "";
            lblReports.Text = SignUp.reports ? "X" : "";
            lblTransactionReports.Text = SignUp.transactions ? "X" : "";

        }
    }
}
