using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class SignIn : Form
    {

        public static string id, name, email, password, country;
        DBAccess objDbAccess = new DBAccess();

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        DataTable dtUsers = new DataTable();



        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmailLogin.Text;
            string userPassword = txtPasswordLogin.Text;

            if(userEmail == "" || userPassword == "")
            {
                MessageBox.Show("Please enter a valid email or password");
            }
            else
            {
                string query = "Select * from Users Where Email='" + userEmail + "' AND Password = '" + userPassword + "'";
                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();

                    MessageBox.Show("Account Created Successfully. Please log in.");
                    objDbAccess.closeConn();

                    this.Hide();
                    HomePage h = new HomePage();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a correct email or password.");
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp h = new SignUp();
            h.Show();
        }
    }
}
