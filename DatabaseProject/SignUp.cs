using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userCountry = txtCountry.Text;

            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your user name");
            }

            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email");
            }

           else  if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your user Password");
            }

            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please enter your user Country");
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name, Email, Password, Country) values(@userName, @userEmail, @userPassword, @userCountry)");
                //SqlCommand insertCommand = new SqlCommand($"insert into Users({userName}, {userEmail}, {userPassword}, {userCountry})");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

                int row = objDBAccess.executeQuery(insertCommand);

                if(row == 1)
                {
                    MessageBox.Show("Account Created Successfully.");

                    this.Hide();
                    SignIn h = new SignIn();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Error Occurred. Try Again.");
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
