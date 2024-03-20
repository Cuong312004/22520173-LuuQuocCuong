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

namespace Lab1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        int CalculateFactorial(int a)
        {
            int result = 1;
            for (int i = a; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
        double CalculateSumOfExponentiation(int numberA, int numberB)
        {
            double sum_expon = 0;
            for (int i = 1; i <= numberB; i++)
            {
                sum_expon += Math.Pow(numberA, i);
            }
            return sum_expon;
        }
        private void buttonTinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Int32.Parse(textBoxA.Text.Trim());
            num2 = Int32.Parse(textBoxB.Text.Trim());
            string selectedValue = comboBoxTinhToan.SelectedItem.ToString();
            switch (selectedValue)
            {
                case "Bảng Cửu Chương":
                    int sub = 0;
                    for (int i = 1; i < 11; i++)
                    {
                        sub = num2 * i - num1 * i;
                        textBoxKQ.AppendText(sub.ToString() + Environment.NewLine);
                    }
                    break;
                default:
                    int factA = CalculateFactorial(num1-num2);
                    double sumExpon = CalculateSumOfExponentiation(num1,num2);
                    textBoxKQ.AppendText("(A-B)! = "+ factA + Environment.NewLine);
                    textBoxKQ.AppendText("Tổng S = A^1 + A^2 + A^3 + A^4 + … + A^B = " + sumExpon + Environment.NewLine);
                    break;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxA.Text = string.Empty;
            textBoxB.Text = string.Empty;
            textBoxKQ.Text = string.Empty;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
