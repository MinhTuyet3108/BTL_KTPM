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
    public partial class Frm_Hasaki_82_Tuyet : Form
    {
        public Frm_Hasaki_82_Tuyet()
        {
            InitializeComponent();
        }
        Hasaki_Controllers_82_Tuyet h_82_Tuyet = new Hasaki_Controllers_82_Tuyet();

        private void btnDangnhap_82_Tuyet_Click(object sender, EventArgs e)
        {
            string username_82_Tuyet = "0522194804";
            string password_82_Tuyet = "33225566";
            h_82_Tuyet.DangNhapHasaki_82_Tuyet(username_82_Tuyet, password_82_Tuyet);

        }

        private void btnTimkiem_82_Tuyet_Click(object sender, EventArgs e)
        {
            //Nhập tên sản phẩm cần tìm kiếm từ text box của form rồi bấm tìm kiếm (Vd: Sữa rửa mặt)
            string word_82_Tuyet = txtTimKiem_82_Tuyet.Text;
            h_82_Tuyet.TimKiem_82_Tuyet(word_82_Tuyet);
        }

        private void btnThemvaogiohang_82_Tuyet_Click(object sender, EventArgs e)
        {
            h_82_Tuyet.Themvaogiohang_82_Tuyet();
        }

        private void btnDoimatkhau_82_Tuyet_Click(object sender, EventArgs e)
        {
            h_82_Tuyet.Doimatkhau_82_Tuyet();
        }
    }
}
