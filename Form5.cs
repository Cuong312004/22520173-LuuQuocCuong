using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form5 : Form
    {
        static string[] DonVi = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        static string[] Chuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        static string[] Tram = { "", "trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = DocSo(long.Parse(textBox1.Text.Trim()));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string DocSoHangTram(long so)
        {
            string chuoi = "";
            if (so == 0)
            {
                chuoi = "không";
            }
            else
            {
                if (so / 100 > 0)
            {
                    chuoi += Tram[so / 100] + " ";
                }
                so %= 100;
                if (so / 10 > 0)
            {
                    chuoi += Chuc[so / 10] + " ";
                }
                if (so % 10 > 0)
                {
                    chuoi += DonVi[so % 10];
                }
            }
            return chuoi;
        }

        static string DocSo(long so)
        {
            if (so == 0)
            {
                return "không";
            }

            string chuoi = "";
            if(so < 0)
            {
                chuoi += "âm ";
                so = -so;
            }    
            
            // Tỷ
            long ty = so / 1000000000;
            if (ty > 0)
            {
                chuoi += DocSoHangTram(ty) + " tỷ ";
            }
            so %= 1000000000;

            // Triệu
            long trieu = so / 1000000;
            if (trieu > 0)
            {
                chuoi += DocSoHangTram(trieu) + " triệu ";
            }
            so %= 1000000;

            // Nghìn
            long nghin = so / 1000;
            if (nghin > 0)
            {
                chuoi += DocSoHangTram(nghin) + " nghìn ";
            }
            so %= 1000;

            // Hàng trăm
            chuoi += DocSoHangTram((int)so);

            return chuoi;
        }

        
    }
}
