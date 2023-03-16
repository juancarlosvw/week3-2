using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_2
{
    public partial class MainForm1 : Form
    {
        public bool secondform = false;
        secondform second = new secondform();
       
        
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void button_nextform_Click(object sender, EventArgs e)
        {
            
            
            
                secondform = true;
                second.Show(this);
            
            
        }

        private void button_submit_Click(object sender, EventArgs e)
        {

            if (txtbox_artist.Text == "" || txtbox_name.Text == "")
            {
                MessageBox.Show("Please fill in the form");
            }
            else if (secondform == true)
            {
                second.changelabel(txtbox_name.Text, txtbox_artist.Text);
               
            }

           
        }
       
        

        private void checkbox_true_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_true.Checked)
            {
                button_submit.Enabled = true;
            }
            if (checkbox_true.Checked == false)
            {
                button_submit.Enabled = false;
            }
        }
    }
}
