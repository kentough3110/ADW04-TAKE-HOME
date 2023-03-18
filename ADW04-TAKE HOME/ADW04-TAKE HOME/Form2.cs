using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADW04_TAKE_HOME
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            button_magic.Enabled = false;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label_change.Parent = pictureBox1;
            label_result.Parent = pictureBox1;
            label_change.BackColor = Color.Transparent;
            label_result.BackColor = Color.Transparent;
            radioButton_Turq.Parent = pictureBox1;
            radioButton_black.Parent = pictureBox1;
            radioButton_olive.Parent = pictureBox1;
            radioButton_navyBlue.Parent = pictureBox1;
            radioButton_Wheat.Parent = pictureBox1;
            radioButton_blackCol.Parent = pictureBox1;
            radioButton_whiteCol.Parent = pictureBox1;
            radioButton_turquoiseCol.Parent = pictureBox1;
            radioButton_Turq.Parent = panel1;
            radioButton_black.Parent = panel1;
            radioButton_olive.Parent = panel1;
            radioButton_navyBlue.Parent = panel1;
            radioButton_Wheat.Parent = panel1;
            radioButton_blackCol.Parent = panel2;
            radioButton_whiteCol.Parent = panel2;
            radioButton_turquoiseCol.Parent = panel2;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            radioButton_Turq.BackColor = Color.Transparent;
            radioButton_black.BackColor = Color.Transparent;
            radioButton_olive.BackColor = Color.Transparent;
            radioButton_navyBlue.BackColor = Color.Transparent;
            radioButton_Wheat.BackColor = Color.Transparent;
            radioButton_blackCol.BackColor = Color.Transparent;
            radioButton_whiteCol.BackColor = Color.Transparent;
            radioButton_turquoiseCol.BackColor = Color.Transparent;
            checkBox_allOfContent.Parent = pictureBox1;
            checkBox_TNC.Parent = pictureBox1;
            checkBox_TNC.BackColor = Color.Transparent;
            checkBox_allOfContent.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            
        }

        public SecondForm(string value1, string value2)
        {
            InitializeComponent();
            button_magic.Enabled = false;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label_change.Parent = pictureBox1;
            label_result.Parent = pictureBox1;
            label_change.BackColor = Color.Transparent;
            label_result.BackColor = Color.Transparent;
            radioButton_Turq.Parent = pictureBox1;
            radioButton_black.Parent = pictureBox1;
            radioButton_olive.Parent = pictureBox1;
            radioButton_navyBlue.Parent = pictureBox1;
            radioButton_Wheat.Parent = pictureBox1;
            radioButton_blackCol.Parent = pictureBox1;
            radioButton_whiteCol.Parent = pictureBox1;
            radioButton_turquoiseCol.Parent = pictureBox1;
            radioButton_Turq.Parent = panel1;
            radioButton_black.Parent = panel1;
            radioButton_olive.Parent = panel1;
            radioButton_navyBlue.Parent = panel1;
            radioButton_Wheat.Parent = panel1;
            radioButton_blackCol.Parent = panel2;
            radioButton_whiteCol.Parent = panel2;
            radioButton_turquoiseCol.Parent = panel2;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            radioButton_Turq.BackColor = Color.Transparent;
            radioButton_black.BackColor = Color.Transparent;
            radioButton_olive.BackColor = Color.Transparent;
            radioButton_navyBlue.BackColor = Color.Transparent;
            radioButton_Wheat.BackColor = Color.Transparent;
            radioButton_blackCol.BackColor = Color.Transparent;
            radioButton_whiteCol.BackColor = Color.Transparent;
            radioButton_turquoiseCol.BackColor = Color.Transparent;
            checkBox_allOfContent.Parent = pictureBox1;
            checkBox_TNC.Parent = pictureBox1;
            checkBox_TNC.BackColor = Color.Transparent;
            checkBox_allOfContent.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            string x = value1;
            string y = value2;
            string z = "Hi, my name is " + value1 + " and my favorite artist is " + value2;
            label_change.Text = z;
        }
        public string LabelChange
        {
            get { return label_change.Text; }
            set { label_change.Text = value; }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_change_Click(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_allOfContent.Checked)
            {
                button_magic.Enabled = false;
            }
            else if (!checkBox_TNC.Checked)
            {
                button_magic.Enabled = false;
            }
            else if(checkBox_allOfContent.Checked == true && checkBox_TNC.Checked == true)
            {
                button_magic.Enabled = true;
            }
        }

        private void checkBox_allOfContent_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_allOfContent.Checked)
            {
                button_magic.Enabled = false;
            }
            else if (!checkBox_TNC.Checked)
            {
                button_magic.Enabled = false;
            }
            else if (checkBox_allOfContent.Checked == true && checkBox_TNC.Checked == true)
            {
                button_magic.Enabled = true;
            }
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            string a = "Please choose one background color before clicking Magic Button";
            string b = "Please choose one text color before clicking Magic Button";
            string c = "Please choose one background color and one text color before clicking Magic Button";
            MainForm mainForm = new MainForm();
            if (!radioButton_Turq.Checked && !radioButton_black.Checked && !radioButton_olive.Checked && !radioButton_navyBlue.Checked && !radioButton_Wheat.Checked)
            {
                MessageBox.Show(a, "Unchecked Radio Button", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if(radioButton_Turq.Checked == true)
            {
                mainForm.BackColor = Color.Turquoise;
                //mainForm.changeBackground(Color.FromArgb(48, 213, 200));
                if (radioButton_blackCol.Checked ==  true)
                {
                    mainForm.changeLabel(Color.FromArgb(0, 0, 0));
                }
                else if(radioButton_whiteCol.Checked == true)
                {
                    mainForm.changeLabel(Color.White);
                }
                else if(radioButton_turquoiseCol.Checked == true)
                {
                    mainForm.changeLabel(Color.Turquoise);
                }
                mainForm.Show();
            }
            else if(radioButton_navyBlue.Checked ==  true)
            {
                mainForm.BackColor = Color.Navy;
                if (radioButton_blackCol.Checked == true)
                {
                    mainForm.changeLabel(Color.FromArgb(0, 0, 0));
                }
                else if (radioButton_whiteCol.Checked == true)
                {
                    mainForm.changeLabel(Color.White);
                }
                else if (radioButton_turquoiseCol.Checked == true)
                {
                    mainForm.changeLabel(Color.Turquoise);
                }
                mainForm.Show();
            }
            else if(radioButton_olive.Checked ==  true)
            {
                mainForm.BackColor = Color.Olive;
                if (radioButton_blackCol.Checked == true)
                {
                    mainForm.changeLabel(Color.FromArgb(0, 0, 0));
                }
                else if (radioButton_whiteCol.Checked == true)
                {
                    mainForm.changeLabel(Color.White);
                }
                else if (radioButton_turquoiseCol.Checked == true)
                {
                    mainForm.changeLabel(Color.Turquoise);
                }
                mainForm.Show();
            }
            else if (radioButton_Wheat.Checked == true)
            {
                mainForm.BackColor = Color.Wheat;
                if (radioButton_blackCol.Checked == true)
                {
                    mainForm.changeLabel(Color.FromArgb(0, 0, 0));
                }
                else if (radioButton_whiteCol.Checked == true)
                {
                    mainForm.changeLabel(Color.FromArgb(0, 0, 0));
                }
                else if (radioButton_turquoiseCol.Checked == true)
                {
                    mainForm.changeLabel(Color.Turquoise);
                }
                mainForm.Show();
            }
            else if (radioButton_black.Checked == true)
            {
                mainForm.BackColor = Color.Black;
                if (radioButton_blackCol.Checked == true)
                {
                    mainForm.changeLabel(Color.FromArgb(0, 0, 0));
                }
                else if (radioButton_whiteCol.Checked == true)
                {
                    mainForm.changeLabel(Color.White);
                }
                else if (radioButton_turquoiseCol.Checked == true)
                {
                    mainForm.changeLabel(Color.Turquoise);
                }
                mainForm.Show();
            }
            if (!radioButton_blackCol.Checked && !radioButton_whiteCol.Checked && !radioButton_turquoiseCol.Checked)
            {
                MessageBox.Show(b, "Unchecked Radio Button", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!radioButton_Turq.Checked && !radioButton_black.Checked && !radioButton_olive.Checked && !radioButton_navyBlue.Checked && !radioButton_Wheat.Checked && !radioButton_blackCol.Checked && !radioButton_whiteCol.Checked && !radioButton_turquoiseCol.Checked)
            {
                MessageBox.Show(c, "Unchecked Radio Button", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_blackCol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_whiteCol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_orangeCol_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
