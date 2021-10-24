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
    public partial class CommandBuilderForm : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public CommandBuilderForm()
        {
            InitializeComponent();
        }

        private void CommandBuilderForm_Load(object sender, EventArgs e)
        {
            string query = "Select * from Users";

            objDbAccess.readDatathroughAdapter(query, dtUsers);

            dataGridView1.DataSource = dtUsers;

            objDbAccess.closeConn();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users";
            int changes = objDbAccess.executeDataAdapter(dtUsers, query);

            MessageBox.Show("count = " + changes);
        }
    }
}
