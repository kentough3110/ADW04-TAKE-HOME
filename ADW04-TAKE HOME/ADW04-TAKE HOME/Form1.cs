using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADW04_TAKE_HOME
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool buttonSubmitClicked = false;
        public void changeLabel(Color color)
        {
            label_header.ForeColor = color;
            label_nama.ForeColor = color;
            label_favArtist.ForeColor = color;
            checkBox_allOf.ForeColor = color;
        }
        public bool isOpen = false;
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            button_submit.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            isOpen = true;
            SecondForm secondForm = new SecondForm();
            if(checkBox_allOf.Checked && isOpen && !buttonSubmitClicked)
            {
                button_submit.Enabled = true;
                secondForm.Show();
            }
            if (isOpen && checkBox_allOf.Checked == true && buttonSubmitClicked == true)
            {
                secondForm = new SecondForm(textBox_nama.Text, textBox_favArtist.Text);
                secondForm.Refresh();
                secondForm.Show();
            }
            
        }
        private void button_submit_Click(object sender, EventArgs e)
        {
            buttonSubmitClicked = true;
            string msgBlank = "Please input your name before clicking Submit Button";
            string msgBlank2 = "Please input your favorite artist before clicking Submit Button";
            string msgBlank3 = "Please input your name and your favorite artist before clicking Submit Button";
            if (textBox_favArtist.Text == "" && textBox_nama.Text == "")
            {
                MessageBox.Show(msgBlank3, "Blank Space", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_nama.Text == "")
            {
                MessageBox.Show(msgBlank, "Blank Space", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_favArtist.Text == "")
            {
                MessageBox.Show(msgBlank2, "Blank Space", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_nama_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        
        private void checkBox_allOf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_allOf.Checked && isOpen)
            {
                button_submit.Enabled = true;
            }
            else
            {
                button_submit.Enabled = false;
            }
        }

        private void label_header_Click(object sender, EventArgs e)
        {

        }
    }
}
