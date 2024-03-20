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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        List<string> lstFoodList = new List<string>();

        private void Form10_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            String text = textBoxNhapMon.Text;
            if (text == null)
            {
                return;
            }
            else
            {
                textBoxMenu.AppendText(text + Environment.NewLine);
                lstFoodList.Add(text);
            }
            textBoxNhapMon.Text = string.Empty;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxNhapMon.Text = string.Empty;
            textBoxMenu.Text = string.Empty;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTimMon_Click(object sender, EventArgs e)
        {
            if (lstFoodList.Count == 0)
            {
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(lstFoodList.Count);

            textBoxMonAn.Text = lstFoodList[randomIndex];
        }
    }
}
