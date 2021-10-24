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
    
    public partial class HomePage : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblWelcomeName.Text = "Welcome " + SignIn.name;

            txtNameHome.Text = SignIn.name;
            txtEmailHome.Text = SignIn.email;
            txtPasswordHome.Text = SignIn.password;
            txtCountryHome.Text = SignIn.country;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string newUserName = txtNameHome.Text;
            string newEmail = txtEmailHome.Text;
            string newPassword = txtPasswordHome.Text;
            string newCountry = txtCountryHome.Text;

            if(newUserName == "" || newEmail == ""|| newPassword == "" || newCountry == "")
            {
                MessageBox.Show("Please make sure all fields are updated");
            }
            else
            {
                string query = "Update Users SET Name = '" + @newUserName + "', Email = '" + @newEmail + "', Password = '" + @newPassword + "', Country = '" + @newCountry + "' where ID = '" + SignIn.id + "'";


                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newCountry);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Information Updated Successfully.");

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

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
            if(dialog == DialogResult.Yes)
            {
                string query = $"DELETE from Users Where ID = '{SignIn.id}'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int deleteQuery = objDBAccess.executeQuery(deleteCommand);

                if (deleteQuery == 1)
                {
                    MessageBox.Show("Account Deleted Successfully.");

                    this.Hide();
                    SignIn h = new SignIn();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Error Occurred when deleting Account. Try Again.");
                }
            }
        }
    }
}
