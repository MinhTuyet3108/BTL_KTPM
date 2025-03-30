using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MixiShop_Selenium_Tester_21_Anh
{
    [TestClass]
    public class Task1_UnitTest_MixiShop_21_Anh
    {

     
        MixiShop_Controllers_21_Anh m_21_Anh = new MixiShop_Controllers_21_Anh();

        [TestMethod]
        //TC1 email = "theanhtran13012004@gmail.com"  matkhau =  "tta130124"  -> kết quả : Pass


        public void TC1_DangNhap_emailDung_matkhauDung_Pass_21_Anh()
        {
            string email_21_Anh = "theanhtran13012004@gmail.com";
            string matkhau_21_Anh = "tta130124";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = m_21_Anh.DangNhapMixiShop_21_Anh(email_21_Anh,matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://shop.mixigaming.com/account";
            Assert.AreEqual(expected_url_21_Anh,actual_url_21_Anh);
            
            
        }
        [TestMethod]
        //TC2 email ="theanhtran13012004@gmail.com"   matkhau ="123456"   -> ket qua : Pass
        public void TC2_DangNhap_emailDung_matkhauSai_Pass_21_Anh()
        {
            string email_21_Anh = "theanhtran13012004@gmail.com";
            string matkhau_21_Anh = "123456";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = m_21_Anh.DangNhapMixiShop_21_Anh(email_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://shop.mixigaming.com/account/login";
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }
        //TC3 email ="abc123@gmail.com"  matkhau="tta130124" -> ket qua : Pass
        public void TC3_DangNhap_emailSai_matkhauDung_Pass_21_Anh()
        {
            string email_21_Anh = "abc123@gmail.com";
            string matkhau_21_Anh = "tta130124";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = m_21_Anh.DangNhapMixiShop_21_Anh(email_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://shop.mixigaming.com/account/login";
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }
        //TC4 email ="abc123@gmail.com"  matkhau="123456" -> ket qua : Pass
        public void TC4_DangNhap_emailSai_matkhauSai_Pass_21_Anh()
        {
            string email_21_Anh = "abc123@gmail.com";
            string matkhau_21_Anh = "tta130124";
            //Endpoint mà kết quả thực sự trả về
            string actual_url_21_Anh = m_21_Anh.DangNhapMixiShop_21_Anh(email_21_Anh, matkhau_21_Anh);
            //Endpoint mà kết quả mong đợi
            string expected_url_21_Anh = "https://shop.mixigaming.com/account/login";
            Assert.AreEqual(expected_url_21_Anh, actual_url_21_Anh);
        }


    }
}
