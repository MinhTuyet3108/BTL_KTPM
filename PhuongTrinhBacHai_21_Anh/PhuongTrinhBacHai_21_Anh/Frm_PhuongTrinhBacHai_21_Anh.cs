using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongTrinhBacHai_21_Anh
{
    public partial class Frm_PhuongTrinhBacHai_21_Anh : Form
    {
        public Frm_PhuongTrinhBacHai_21_Anh()
        {
            InitializeComponent();
        }

        private double[] Nghiem_21_Anh;
        private string KetQua_21_Anh;

        private void btnXemKQ_21_Anh_Click(object sender, EventArgs e)
        {
            try
            {
                double a_21_Anh = double.Parse(txtHeSoA_21_Anh.Text);
                double b_21_Anh = double.Parse(txtHeSoB_21_Anh.Text);
                double c_21_Anh = double.Parse(txtHeSoC_21_Anh.Text);




                //do phương thức GiaiPhuongTrinhBacHai_21_Anh là static nên không cần tạo đói tượng PhepTinhPhuongTrinhBacHai_21_Anh
                PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_21_Anh, out KetQua_21_Anh, a_21_Anh, b_21_Anh, c_21_Anh);


                lblKetQua_21_Anh.Text = KetQua_21_Anh;

            }
            //Trường hợp người dùng không nhập vào số -> thì phải quăng ra ngoại lệ này FormatException
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}