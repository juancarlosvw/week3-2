using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3_2
{
    public partial class secondform : Form
    {
        public secondform()
        {
            InitializeComponent();
        }

        private void secondform_Load(object sender, EventArgs e)
        {

        }

        public void changelabel(string name, string artist)
        {
            label_mynameis.Text = $"Hi, my name {name} and my favorite artist is {artist}";
        }

       
        
        
        private void button_magic_Click(object sender, EventArgs e)
        {
            //MainForm1 form1 = new MainForm1();
            MainForm1 form1 = (MainForm1)this.Owner;
           
            if (rbutton_red.Checked == false && rbutton_blue.Checked == false && rbutton_green.Checked == false && rbutton_purple.Checked == false && rbutton_yellow.Checked == false && rbutton_yellow.Checked == false || (rbutton_textblue.Checked == false && rbutton_textgreen.Checked == false && rbutton_textred.Checked == false))
            {

                MessageBox.Show("Please fill in the form");
            }
            else
            {
                if (rbutton_red.Checked)
                {
                    form1.BackColor = Color.Red;
                }
                if (rbutton_green.Checked)
                {
                    form1.BackColor = Color.Green;
                }
                if (rbutton_blue.Checked)
                {
                    form1.BackColor = Color.Blue;
                }
                if (rbutton_yellow.Checked)
                {
                    form1.BackColor = Color.Yellow;
                }
                if (rbutton_purple.Checked)
                {
                    form1.BackColor = Color.Purple;
                }
                if (rbutton_textred.Checked)
                {
                    form1.ForeColor = Color.Red;
                }
                if (rbutton_textgreen.Checked)
                {
                    form1.ForeColor = Color.Green;
                }
                if (rbutton_textblue.Checked)
                {
                    form1.ForeColor = Color.Blue;
                }
            }

           
        }

        private void checkbox_agreement_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox_agreement.Checked && checkbox_choice.Checked)
            {
                button_magic.Enabled = true;
            }
            if (checkbox_agreement.Checked == false)
            {
                button_magic.Enabled = false;
            }
        }

        private void checkbox_choice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_choice.Checked && checkbox_agreement.Checked)
            {
                button_magic.Enabled = true;
            }
            if (checkbox_choice.Checked == false)
            {
                button_magic.Enabled = false;
            }
        }
    }
}
