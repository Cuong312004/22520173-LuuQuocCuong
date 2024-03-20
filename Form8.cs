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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = dateTimePicker1.Value;

            string cungHoangDao = "";
            switch (ngaySinh.Month)
            {
                case 1:
                    if (ngaySinh.Day >= 20)
                        cungHoangDao = "Bảo Bình";
                    else
                        cungHoangDao = "Ma Kết";
                    break;
                case 2:
                    if (ngaySinh.Day >= 19)
                        cungHoangDao = "Song Ngư";
                    else
                        cungHoangDao = "Bảo Bình";
                    break;
                case 3:
                    if (ngaySinh.Day >= 21)
                        cungHoangDao = "Bạch Dương";
                    else
                        cungHoangDao = "Song Ngư";
                    break;
                case 4:
                    if (ngaySinh.Day >= 20)
                        cungHoangDao = "Kim Ngưu";
                    else
                        cungHoangDao = "Bạch Dương";
                    break;
                case 5:
                    if (ngaySinh.Day >= 21)
                        cungHoangDao = "Song Tử";
                    else
                        cungHoangDao = "Kim Ngưu";
                    break;
                case 6:
                    if (ngaySinh.Day >= 22)
                        cungHoangDao = "Cự Giải";
                    else
                        cungHoangDao = "Song Tử";
                    break;
                case 7:
                    if (ngaySinh.Day >= 23)
                        cungHoangDao = "Sư Tử";
                    else
                        cungHoangDao = "Cự Giải";
                    break;
                case 8:
                    if (ngaySinh.Day >= 23)
                        cungHoangDao = "Xử Nữ";
                    else
                        cungHoangDao = "Sư Tử";
                    break;
                case 9:
                    if (ngaySinh.Day >= 24)
                        cungHoangDao = "Thiên Bình";
                    else
                        cungHoangDao = "Xử Nữ";
                    break;
                case 10:
                    if (ngaySinh.Day >= 23)
                        cungHoangDao = "Thần Nông";
                    else
                        cungHoangDao = "Thiên Bình";
                    break;
                case 11:
                    if (ngaySinh.Day >= 22)
                        cungHoangDao = "Nhân Mã";
                    else
                        cungHoangDao = "Thần Nông";
                    break;
                case 12:
                    if (ngaySinh.Day >= 21)
                        cungHoangDao = "Ma Kết";
                    else
                        cungHoangDao = "Nhân Mã";
                    break;
            }

            // Hiển thị cung hoàng đạo
            textBoxCHĐ.Text = cungHoangDao;
        }
    }
}
