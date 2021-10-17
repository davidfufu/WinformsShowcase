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

            listBox1.DataSource = dtCourses;
            listBox1.DisplayMember = "CourseName";

            listBox2.DataSource = dtSelectedCourses;
            listBox2.DisplayMember = "CourseName";
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
            dtSelectedCourses.Columns.Add("CourseID", typeof(int));
            dtSelectedCourses.Columns.Add("CourseName");
            dtSelectedCourses.Columns.Add("CourseDuration");


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                dtCourses.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                //dtSelectedCourses.ImportRow()
                int Count = dtCourses.Rows.Count;

                for(int i = Count-1; i >=0; i--)
                {
                    dtSelectedCourses.ImportRow(dtCourses.Rows[i]);
                    dtCourses.Rows[i].Delete();
                }
           
            }
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                int Count = dtSelectedCourses.Rows.Count;

                for (int i = Count - 1; i >= 0; i--)
                {
                    dtCourses.ImportRow(dtSelectedCourses.Rows[i]);
                    dtSelectedCourses.Rows[i].Delete();
                }
            }
        }


        private void FinalizeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
