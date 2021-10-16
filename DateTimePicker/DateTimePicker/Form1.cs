using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblDateTime.Text = dtPicker.Value.ToString();
            lblDate.Text = dtPicker.Value.ToShortDateString();
            lblDateDay.Text = dtPicker.Value.ToLongDateString();

        }
    }
}
