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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            switch (num = Int32.Parse(textBox1.Text.Trim()))
            {
                case 0:
                    label3.Text = "Không";
                    break;
                case 1:
                    label3.Text = "Một";
                    break;
                case 2:
                    label3.Text = "Hai";
                    break;
                case 3:
                    label3.Text = "Ba";
                    break;
                case 4:
                    label3.Text = "Bốn";
                    break;
                case 5:
                    label3.Text = "Năm";
                    break;
                case 6:
                    label3.Text = "Sáu";
                    break;
                case 7:
                    label3.Text = "Bảy";
                    break;
                case 8:
                    label3.Text = "Tám";
                    break;
                case 9:
                    label3.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Warning!");
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
