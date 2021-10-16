using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxTest
{
    public partial class Form1 : Form
    {
        private DataTable dtCourses = new DataTable();
        private DataTable dtSelectedCourses = new DataTable();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCourseTable();
            SelectedCourses();
        }


        private void FillCourseTable()
        {
            dtCourses.Columns.Add("CourseID", typeof(int));
            dtCourses.Columns.Add("CourseName");
            dtCourses.Columns.Add("CourseDuration");

            dtCourses.Rows.Add(1, "Advance OOP", "4 months");
            dtCourses.Rows.Add(2, "Formal Methods", "5 Months");
            dtCourses.Rows.Add(3, "Web Designing", "6 Months");
            dtCourses.Rows.Add(4, "Web Engineer", "4 Months");
            dtCourses.Rows.Add(4, "ITC", "5 months");

        }

        private void SelectedCourses()
        {
            dtCourses.Columns.Add("CourseID", typeof(int));
            dtCourses.Columns.Add("CourseName");
            dtCourses.Columns.Add("CourseDuration");


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                dtSelectedCourses.Rows.Add(dtCourses.Rows[listBox1.SelectedIndex]);
                dtCourses.Rows[listBox1.SelectedIndex].Delete();
            }
            
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtCourses.Rows.Add(dtCourses.Rows[listBox2.SelectedIndex]);
                dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
            }
        }
    }
}
