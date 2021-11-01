using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownTest
{
    public partial class Form1 : Form
    {
        DataTable dtClinic = new DataTable();

        DataTable dtDoctors = new DataTable();

        DataTable dtSpecificDoctors = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillClinicTable();
            FillDoctorTable();
            comboBox1.DataSource = dtClinic;

            comboBox1.DisplayMember = "CName";
        }

        private void FillClinicTable()
        {
            dtClinic.Columns.Add("CID", typeof(int));
            dtClinic.Columns.Add("CName");
            dtClinic.Columns.Add("CAddress");
            dtClinic.Columns.Add("CRating");

            dtClinic.Rows.Add(1, "Dentist Pro Clinic", "Palm Beach", "5/10");
            dtClinic.Rows.Add(2, "Fufu Clinic", "Innisfil  Beach", "9/10");
            dtClinic.Rows.Add(3, "Teeth Art Clinic", "Well Avenue", "5/30");
            dtClinic.Rows.Add(4, "Castle Orthodontics Clinic", "Hunter Street", "40/10");
        }


        private void FillDoctorTable()
        {
            dtDoctors.Columns.Add("CID", typeof(int));
            dtDoctors.Columns.Add("DName");

            dtDoctors.Columns.Add("DSpeciality");
            dtDoctors.Columns.Add("DContact");

            dtDoctors.Rows.Add(1, "Angelica", "Cosmetic Dentistry", "4761651651");
            dtDoctors.Rows.Add(1, "Mark", "Palate Adjustment", "65484684");
            dtDoctors.Rows.Add(1, "John", "Cosmetic Dentistry", "784684");
            dtDoctors.Rows.Add(1, "Hamilton", "Cleaning", "789468");

            dtDoctors.Rows.Add(2, "Joe", "Cosmetic Dentistry", "2222234234");
            dtDoctors.Rows.Add(2, "Manny", "Palate Adjustment", "234234234");
            dtDoctors.Rows.Add(2, "Patrick", "Palate Adjustment", "665343234");

            dtDoctors.Rows.Add(3, "Mogbi", "Cosmetic Dentistry", "3215481");
            dtDoctors.Rows.Add(4, "Ash", "Palate Adjustment", "3216548");
        }

        private void lblClinicName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CID"].ToString();
            lblClinicName.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CName"].ToString();
            lblAddress.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CAddress"].ToString();
            lblRating.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CRating"].ToString();

            dtSpecificDoctors = dtDoctors.Select("CID = " + dtClinic.Rows[comboBox1.SelectedIndex]["CID"]).CopyToDataTable();

            comboBox2.DataSource = dtSpecificDoctors;
            comboBox2.DisplayMember = "DName";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDoctorName.Text = dtSpecificDoctors.Rows[comboBox2.SelectedIndex]["DName"].ToString();
            lblDoctorSpeciality.Text = dtSpecificDoctors.Rows[comboBox2.SelectedIndex]["DSpeciality"].ToString();
            lblDoctorContact.Text = dtSpecificDoctors.Rows[comboBox2.SelectedIndex]["DContact"].ToString();
        }
    }
}
