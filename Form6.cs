using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        Dictionary<string, string> textboxes = new Dictionary<string, String>();

        public object MaterialMessageBox { get; private set; }

        private void comboBoxPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxPhim.SelectedItem.ToString();
            if (selectedValue != null)
            {
                switch (selectedValue)
                {
                    case "Mai":
                        comboBox1PChieu.Refresh();
                        comboBox1PChieu.SelectedItem = null;
                        comboBox1PChieu.Items.Clear();

                        comboBox1PChieu.Items.Add("Phòng chiếu 2");
                        comboBox1PChieu.Items.Add("Phòng chiếu 3");
                        break;
                    case "Gặp lại chị bầu":
                        comboBox1PChieu.Refresh();
                        comboBox1PChieu.SelectedItem = null;
                        comboBox1PChieu.Items.Clear();

                        comboBox1PChieu.Items.Add("Phòng chiếu 1");
                        break;
                    case "Tarot":
                        comboBox1PChieu.Refresh();
                        comboBox1PChieu.SelectedItem = null;
                        comboBox1PChieu.Items.Clear();

                        comboBox1PChieu.Items.Add("Phòng chiếu 3");
                        break;
                    default:
                        comboBox1PChieu.Refresh();
                        comboBox1PChieu.SelectedItem = null;
                        comboBox1PChieu.Items.Clear();

                        comboBox1PChieu.Items.Add("Phòng chiếu 1");
                        comboBox1PChieu.Items.Add("Phòng chiếu 2");
                        comboBox1PChieu.Items.Add("Phòng chiếu 3");
                        break;
                }
            }
        }

        private void comboBox1PChieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelDPP1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonCHON_Click(object sender, EventArgs e)
        {
            panelDPP1.Visible = true;
        }

        public static double DonGiaChuan(string Film)
        {
            switch (Film)
            {
                case "Đào, phở và piano":
                    return 45000;
                case "Mai":
                    return 100000;
                case "Gặp lại chị bầu":
                    return 70000;
                default:
                    return 90000;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string text = button.Text;
            textBoxGhe.Text = text;
            string FilmName = comboBoxPhim.SelectedItem.ToString();
            double giave = 0;
            if (text.Equals("A1") || text.Equals("A5") || text.Equals("C1") || text.Equals("C5"))
            {
                giave = DonGiaChuan(FilmName) / 4 ;
                textBoxGiave.Text = giave.ToString() + " VNĐ";
            }
            else if (text.Equals("B2") || text.Equals("B3") || text.Equals("B4"))
            {
                giave = DonGiaChuan(FilmName) * 2;
                textBoxGiave.Text = giave.ToString() + " VNĐ";
            }
            else
            {
                giave = DonGiaChuan(FilmName) ;
                textBoxGiave.Text = giave.ToString() + " VNĐ";
            }    
        }

        private void textBoxGiave_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDatve_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string FilmName = comboBoxPhim.SelectedItem.ToString();
            string Room = comboBox1PChieu.SelectedItem.ToString();
            string Seat = textBoxGhe.Text;
            string Cost = textBoxGiave.Text;
            MessageBox.Show(
            $"Tên Khách Hàng: " + Name + "\n" +
            $"Tên Phim: " + FilmName + "\n" +
            $"Rạp: " + Room + "\n" +
            $"Ghế: " + Seat + "\n" +
            $"Giá vé: " + Cost ,
            "Thông tin đặt vé",
            MessageBoxButtons.OK);
        }

        private void textBoxGhe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
