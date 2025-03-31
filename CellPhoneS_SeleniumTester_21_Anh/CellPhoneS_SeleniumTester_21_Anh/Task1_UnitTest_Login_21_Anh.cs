using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
    [TestClass]
    public class Task1_UnitTest_Login_21_Anh
    {
        
        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();

        [TestMethod]
        //TC1 sđt="0933033801"  matkhau =  "tta1301"  -> kết quả : Pass
        public void TC1_DangNhap_sđtDung_matkhauDung_Pass_21_Anh()
        {
            string sđt_21_Anh = "0933033801";
            string matkhau_21_Anh = "tta1301";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://cellphones.com.vn/smember/";
            Assert.AreEqual(expected_url_21_Anh,actual_url_21_Anh);
            
            
        }
        [TestMethod]
        //TC2   matkhau ="123456"   -> ket qua : Pass
        public void TC2_DangNhap_sđtDung_matkhauSai_Pass_21_Anh()
        {
            string sđt_21_Anh = "0933033801";
            string matkhau_21_Anh = "123456";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://account.cellphones.com.vn/?redirect_uri=https%3A%2F%2Fcellphones.com.vn%2Fsmember%2F";
            
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }
        ////TC3 " -> ket qua : Pass
        //public void TC3_DangNhap_sđtSai_matkhauDung_Pass_21_Anh()
        //{
        //    string sđt_21_Anh = "abc123@gmail.com";
        //    string matkhau_21_Anh = "tta130124";
        //    //Endpoint mà kết quả thực sự trả về
        //    string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
        //    //Endpoint mà kết quả mong đợi
        //    string expected_url_21_Anh = "https://shop.mixigaming.com/account/login";
        //    Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        //}
        ////TC4  -> ket qua : Pass
        //public void TC4_DangNhap_sđtSai_matkhauSai_Pass_21_Anh()
        //{
        //    string sđt_21_Anh = "abc123@gmail.com";
        //    string matkhau_21_Anh = "tta130124";
        //    //Endpoint mà kết quả thực sự trả về
        //    string actual_url_21_Anh = c_21_Anh.DangNhapCellPhoneS_21_Anh(sđt_21_Anh, matkhau_21_Anh);
        //    //Endpoint mà kết quả mong đợi
        //    string expected_url_21_Anh = "https://shop.mixigaming.com/account/login";
        //    Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        //}
    }
}
