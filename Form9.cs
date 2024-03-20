using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.Trim();
            string[] Str = Text.Split(',');
            textBox2.AppendText("Họ và Tên : " + Str[0] + Environment.NewLine);
        }

        private void buttonDiem_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.Trim();
            string[] Str = Text.Split(',');
            for(int i = 1; i < Str.Length; i++)
            {
                textBox2.AppendText("Môn " + i + " : " + Str[i] + Environment.NewLine);
            }      
        }
        private void buttonĐTB_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.Trim();
            string[] Str = Text.Split(',');
            double dtb = 0;
            for(int i = 0; i < (Str.Length)-1; i++)
            {
                Str[i] = Str[i+1];
            }
            double[] dbArray = new double[Str.Length-1];

            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                if (double.TryParse(Str[i], out double number))
                {
                    dbArray[i] = number;
                }
            }

            for(int i=0; i < dbArray.Length; i++)
            {
                dtb += dbArray[i];
            }
            dtb = dtb/dbArray.Length;
            textBox2.AppendText("Điểm trung bình: " + dtb + Environment.NewLine);
        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.Trim();
            string[] Str = Text.Split(',');
            double max = 0;
            int imax = 0;
            double min = 10;
            int imin = 0;
            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                Str[i] = Str[i + 1];
            }
            double[] dbArray = new double[Str.Length - 1];

            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                if (double.TryParse(Str[i], out double number))
                {
                    dbArray[i] = number;
                }
            }
            for(int i=0;i < dbArray.Length; i++)
            {
                if (dbArray[i] > max)
                {
                    max = dbArray[i];
                    imax = i+1;
                }
            }
            for (int i = 0; i < dbArray.Length; i++)
            {
                if (dbArray[i] < min)
                {
                    max = dbArray[i];
                    imin = i+1;
                }
            }
            textBox2.AppendText("Môn điểm cao nhất: Môn " + imax + Environment.NewLine);
            textBox2.AppendText("Môn điểm thấp nhất: Môn " + imin + Environment.NewLine);
        }

        private void buttondaukhong_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.Trim();
            string[] Str = Text.Split(',');
            int countPass = 0;
            int countFail = 0;
            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                Str[i] = Str[i + 1];
            }
            double[] dbArray = new double[Str.Length - 1];

            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                if (double.TryParse(Str[i], out double number))
                {
                    dbArray[i] = number;
                }
            }
            for (int i = 0; i < dbArray.Length; i++)
            {
                if (dbArray[i] >= 5)
                    countPass++;
                else
                    countFail++;  
            }
            textBox2.AppendText("Số Môn Đậu: " + countPass + Environment.NewLine);
            textBox2.AppendText("Số Môn Rớt: " + countFail + Environment.NewLine);
        }

        private void buttonXepLoai_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text.Trim();
            string[] Str = Text.Split(',');
            double dtb = 0;
            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                Str[i] = Str[i + 1];
            }
            double[] dbArray = new double[Str.Length - 1];

            for (int i = 0; i < (Str.Length) - 1; i++)
            {
                if (double.TryParse(Str[i], out double number))
                {
                    dbArray[i] = number;
                }
            }
            for (int i = 0; i < dbArray.Length; i++)
            {
                dtb += dbArray[i];
            }
            dtb = dtb / dbArray.Length;
            if (dtb >= 8 && dbArray.All(score => score >= 6.5))
            {
                textBox2.AppendText("Xếp Loại: Giỏi" + Environment.NewLine);
            }
            else if (dtb >= 6.5 && dbArray.All(score => score >= 5))
            {
                textBox2.AppendText("Xếp Loại: Khá" + Environment.NewLine);
            }
            else if (dtb >= 5 && dbArray.All(score => score >= 3.5))
            {
                textBox2.AppendText("Xếp Loại: Trung Bình" + Environment.NewLine);
            }
            else if (dtb >= 3.5 && dbArray.All(score => score >= 2))
            {
                textBox2.AppendText("Xếp Loại: Yếu" + Environment.NewLine);
            }
            else
            {
                textBox2.AppendText("Xếp Loại: Kém" + Environment.NewLine);
            }
        }
    }
}
