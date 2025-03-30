using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Thêm dòng này để làm việc với Selenium
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MixiShop_Selenium_Tester_21_Anh
{
    class MixiShop_Controllers_21_Anh 
    {
        IWebDriver driver_21_Anh = new ChromeDriver();
        public void TruyCapTrangChu_21_Anh () { 
            
            driver_21_Anh.Navigate().GoToUrl("https://shop.mixigaming.com/");
        }
        
        public string DangNhapMixiShop_21_Anh(string email_21_Anh , string matkhau_21_Anh)
        {
            TruyCapTrangChu_21_Anh();
            // cho web dừng 1s để load trang chủ
            Thread.Sleep(2000); 
            //Click vào để hiện dropdown đăng nhập
            driver_21_Anh.FindElement(By.Id("icon-account")).Click();

            //Lấy element nút đăng nhập 
            IWebElement element_21_Anh = driver_21_Anh.FindElement(By.LinkText("Đăng nhập"));
            //Nhấn vào để kiểm tra thông tin đăng nhập
            element_21_Anh.Click();

            //Lấy element nhập email
            IWebElement element_email_21_Anh = driver_21_Anh.FindElement(By.Name("email"));
            //Gửi mật khẩu được truyền bên project test
            element_email_21_Anh.SendKeys(email_21_Anh);
            //Lấy element nhập mật khẩu
            IWebElement element_mk_21_Anh = driver_21_Anh.FindElement(By.Name("password"));
            element_mk_21_Anh.SendKeys(matkhau_21_Anh);
            //Lấy element button đăng nhập
            IWebElement element_submit_21_Anh = driver_21_Anh.FindElement(By.ClassName("btn-login"));
            element_submit_21_Anh.Click();


            string url_hientai_21_Anh = driver_21_Anh.Url;
            
            driver_21_Anh.Close();

            //Trả về url hiện tại của trang web
            return url_hientai_21_Anh;





        }
    }
}
