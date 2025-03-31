using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CellPhoneS_SeleniumTester_21_Anh
{
    class CellPhoneS_Controllers_21_Anh
    {

        IWebDriver driver_21_Anh = new ChromeDriver();
        public void TruyCapTrangChu_21_Anh()
        {

            driver_21_Anh.Navigate().GoToUrl("https://cellphones.com.vn/");
        }

        public string DangNhapCellPhoneS_21_Anh(string sđt_21_Anh, string matkhau_21_Anh)
        {
            TruyCapTrangChu_21_Anh();
            // cho web dừng 2s để load trang chủ
            Thread.Sleep(2000);
            //Click vào để vào đăng nhập
            driver_21_Anh.FindElement(By.ClassName("login-btn")).Click();
            // cho web dừng 2s để load nút đăng nhập
            Thread.Sleep(2000);
            //Click chuyển tới trang đăng nhập
            driver_21_Anh.FindElement(By.CssSelector(".modal-login .login-btn")).Click();


            //Lấy element nhập số điện thoại
            IWebElement element_sđt_21_Anh = driver_21_Anh.FindElement(By.CssSelector("input[type='tel']"));
            //Gửi mật khẩu được truyền bên project test
            element_sđt_21_Anh.SendKeys(sđt_21_Anh);
            //Lấy element nhập mật khẩu
            IWebElement element_mk_21_Anh = driver_21_Anh.FindElement(By.CssSelector("input[type='password']"));
            element_mk_21_Anh.SendKeys(matkhau_21_Anh);
            //Lấy element button đăng nhập
            IWebElement element_submit_21_Anh = driver_21_Anh.FindElement(By.ClassName("button__login"));
            element_submit_21_Anh.Click();

            //Nếu đã đăng nhập ddc có thể chuyển tới trang này 
            Thread.Sleep(2000);

            driver_21_Anh.Navigate().GoToUrl("https://cellphones.com.vn/smember/");

            string url_hientai_21_Anh = driver_21_Anh.Url;

            driver_21_Anh.Close();

            //Trả về url hiện tại của trang web
            return url_hientai_21_Anh;
        }
        public bool TimKiemSanPham_21_Anh(string tuTimKiem_21_Anh)
        {
            TruyCapTrangChu_21_Anh();
            Thread.Sleep(2000);
            // Tìm ô tìm kiếm và nhập từ khóa
            IWebElement element_search_21_Anh = driver_21_Anh.FindElement(By.Id("inp$earch"));
            element_search_21_Anh.SendKeys(tuTimKiem_21_Anh);
            Thread.Sleep(1000);
            element_search_21_Anh.Submit();
            Thread.Sleep(5000);
            // Lấy danh sách sản phẩm hiển thị
            ReadOnlyCollection<IWebElement> list_product_21_Anh = driver_21_Anh.FindElements(By.CssSelector(".product-item h3"));

            // Kiểm tra xem có sản phẩm nào chứa "Iphone 16" hay không
            foreach (var product_21_Anh in list_product_21_Anh)
            {
                if (product_21_Anh.Text.Contains("Iphone 16"))
                {
                    return true; // Sản phẩm tồn tại

                }
            }
            return false; // Không tìm thấy sản phẩm
        }

    }
}
