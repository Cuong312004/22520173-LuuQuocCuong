using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            num1 = Double.Parse(textBox1.Text.Trim());
            num2 = Double.Parse(textBox2.Text.Trim());
            num3 = Double.Parse(textBox3.Text.Trim());
            double SLN, SNN;
            SLN = Math.Max(num1,Math.Max(num2,num3));
            SNN = Math.Min(num1,Math.Min(num2,num3));
            label6.Text = SLN.ToString();
            label7.Text = SNN.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Text = string.Empty;
             textBox2.Text = string.Empty;
             textBox3.Text = string.Empty;
        }
    }
}
