using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
    [TestClass]
    public class Task1_UnitTest_Login_21_Anh
    {
        
        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();


        [TestMethod]
        //TC1  sđt_21_Anh = "0933033801", matkhau ="123456"   -> ket qua : Pass -> do sai mật khẩu nên kết quả mong đợi trả ra url
        //https://account.cellphones.com.vn/?redirect_uri=https%3A%2F%2Fcellphones.com.vn%2Fsmember%2F và cũng đúng với url của kết quá thật sự
        public void TC1_DangNhap_sđtDung_matkhauSai_Pass_21_Anh()
        {
            string sđt_21_Anh = "0933033801";
            string matkhau_21_Anh = "123456";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi -> có thêm tham số redirect vì nó luôn về members
            string expected_url_21_Anh = "https://account.cellphones.com.vn/?redirect_uri=https%3A%2F%2Fcellphones.com.vn%2Fsmember%2F"; 
            
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }

        [TestMethod]
        //TC2 sđt="0933033801"  matkhau =  "tta1301"  -> kết quả : Pass -> do đúng thông tin đăng nhập và kết quả mong đợi
        //trả về url https://cellphones.com.vn/smember/ cũng đúng với url của kết quả thực sự
        public void TC2_DangNhap_sđtDung_matkhauDung_Pass_21_Anh()
        {
            string sđt_21_Anh = "0933033801";
            string matkhau_21_Anh = "tta1301";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://cellphones.com.vn/smember/";
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);


        }
        [TestMethod]
        //TC3 "sđt = "0933033234", matkhau ="tta130124" -> ket qua : Fail -> do sai sđt mà kết quả mong đợi trả ra url
        //https://cellphones.com.vn/smember/ không đúng với url mà kết quả thật sự trả ra là  https://account.cellphones.com.vn/?redirect_uri=https%3A%2F%2Fcellphones.com.vn%2Fsmember%2F
        public void TC3_DangNhap_sđtSai_matkhauDung_Fail_21_Anh()
        {
            string sđt_21_Anh = "0933033234";
            string matkhau_21_Anh = "tta130124";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://cellphones.com.vn/smember/";
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }
        [TestMethod]
        //TC4  "sđt = "01232421421", matkhau ="@12352213" -> ket qua : Fail do sai sđt và sai mật khẩu mà kết quả mong đợi trả ra url
        //https://cellphones.com.vn/smember/ không đúng với url mà kết quả thật sự trả ra là  https://account.cellphones.com.vn/?redirect_uri=https%3A%2F%2Fcellphones.com.vn%2Fsmember%2F
        public void TC4_DangNhap_sđtSai_matkhauSai_Fail_21_Anh()
        {
            string sđt_21_Anh = "01232421421";
            string matkhau_21_Anh = "@12352213";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://cellphones.com.vn/smember/";
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }
    }
}
