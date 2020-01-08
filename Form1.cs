using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redo
{
    public partial class Form1 : Form
    {
        Class1 degree = new Class1(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                double value = Double.Parse(textBox1.Text);
                res.Text = degree.CtoF(value).ToString();
            }
            else if (radioButton2.Checked)
            {
                double value = Double.Parse(textBox1.Text);
                res.Text = degree.FtoC(value).ToString();
            }
            else if (radioButton3.Checked)
            {
                double value = double.Parse(textBox1.Text);
                res.Text = degree.FtoK(value).ToString();
            }
            else if (radioButton4.Checked)
            {
                double value = double.Parse(textBox1.Text);
                res.Text = degree.CtoK(value).ToString();
            }
            else if (radioButton5.Checked)
            {
                double value = double.Parse(textBox1.Text);
                res.Text = degree.KtoF(value).ToString();
            }
            else if (radioButton6.Checked)
            {
                double value = double.Parse(textBox1.Text);
                res.Text = degree.KtoC(value).ToString();
            }
            
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
