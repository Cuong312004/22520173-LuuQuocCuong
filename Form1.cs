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
    public partial class lab1 : Form
    {
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private Form4 form4 = new Form4();
        private Form5 form5 = new Form5();
        private Form6 form6 = new Form6();
        private Form7 form7 = new Form7();
        private Form8 form8 = new Form8();
        private Form9 form9 = new Form9();
        private Form10 form10 = new Form10();
        public lab1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form4.Show();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form6.Show();
        }

        private void buttonBai5_Click(object sender, EventArgs e)
        {
            form7.Show();
        }

        private void buttonBai6_Click(object sender, EventArgs e)
        {
            form8.Show();
        }

        private void buttonBai7_Click(object sender, EventArgs e)
        {
            form9.Show();   
        }

        private void buttonBai8_Click(object sender, EventArgs e)
        {
            form10.Show();
        }
    }
}
