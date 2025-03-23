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

        private void btnXemKQ_21_Anh_Click(object sender, EventArgs e)
        {
            try
            {
                double a_21_Anh = double.Parse(txtHeSoA_21_Anh.Text);
                double b_21_Anh = double.Parse(txtHeSoB_21_Anh.Text);
                double c_21_Anh = double.Parse(txtHeSoC_21_Anh.Text);

      
                double[] nghiem;
                string ketQua;


                PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out nghiem, out ketQua, a_21_Anh, b_21_Anh, c_21_Anh);


                lblKetQua_21_Anh.Text = ketQua;

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}