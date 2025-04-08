using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Selenium_21_Anh
{
    public partial class Frm_CellPhoneS_21_Anh_: Form
    {
        public Frm_CellPhoneS_21_Anh_()
        {
            InitializeComponent();
        }

        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();
        private void btn_DangNhap_21_Anh_Click(object sender, EventArgs e)
        {
            string sdt_21_Anh = "0933033801";
            string password_21_Anh = "tta1301";
            c_21_Anh.DangNhapCellPhoneS_21_Anh(sdt_21_Anh,password_21_Anh);
        }

        private void btnTimKiemSanPham_21_Anh_Click(object sender, EventArgs e)
        {
            //Nhập tên sản phẩm cần tìm kiếm từ text box của form rồi bấm tìm kiếm (Vd: Iphone16)
            string tutimkiem_21_Anh = txtTenSanPham_21_Anh.Text;
            c_21_Anh.TimKiemSanPham_21_Anh(tutimkiem_21_Anh);
        }

        private void btnXemLichSuMuaHang_21_Anh_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhGia_21_Anh_Click(object sender, EventArgs e)
        {

        }
    }
}
