using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonTest
{
    public partial class RadioButton : Form
    {
        public string selection;
        public RadioButton()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
            selection = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = false;
            //radioButton3.Checked = false;
            selection = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            selection = radioButton3.Text;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selection);
        }

        private void purchasButton_Click(object sender, EventArgs e)
        {
            DialogResult dr =MessageBox.Show("1: To Purchase, Press = YES \n 2: For trial verion, Press = 2 \n Cancel Order", "Software Purchase", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if(dr == DialogResult.Yes)
            {
                responseText.Text = "THank you for Purchasing";
            }
            else if(dr == DialogResult.No)
            {
                responseText.Text = "We're sorry to see you go";
            }

            else if(dr == DialogResult.Cancel)
            {
                responseText.Text = "....";
            }

        }
    }
}
