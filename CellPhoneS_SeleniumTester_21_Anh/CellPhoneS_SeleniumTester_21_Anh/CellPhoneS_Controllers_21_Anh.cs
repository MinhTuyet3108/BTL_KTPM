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
        //Tạo ra đối tượng Driver
        IWebDriver driver_21_Anh = new ChromeDriver();

        //Phương thức truy cập trang chủ
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
            //Gửi số điện thoại 
            element_sđt_21_Anh.SendKeys(sđt_21_Anh);
            //Lấy element nhập mật khẩu
            IWebElement element_mk_21_Anh = driver_21_Anh.FindElement(By.CssSelector("input[type='password']"));
            //Gửi mật khẩu điện thoại 
            element_mk_21_Anh.SendKeys(matkhau_21_Anh);
            //Lấy element button đăng nhập
            IWebElement element_submit_21_Anh = driver_21_Anh.FindElement(By.ClassName("button__login"));
            element_submit_21_Anh.Click();

            //Nếu đã đăng nhập được có thể chuyển tới trang này -> vì nó không tự chuyển về trang member
            Thread.Sleep(2000);
            driver_21_Anh.Navigate().GoToUrl("https://cellphones.com.vn/smember/");

            string url_hientai_21_Anh = driver_21_Anh.Url;

            driver_21_Anh.Close();

            //Trả về url hiện tại của trang web
            return url_hientai_21_Anh;
        }
        public bool TimKiemSanPham_21_Anh(string tuTimKiem_21_Anh)
        {
            try
            {
                TruyCapTrangChu_21_Anh();
                //Dừng 2s để chờ web load
                Thread.Sleep(2000);
                // Tìm ô tìm kiếm và nhập từ khóa
                IWebElement element_search_21_Anh = driver_21_Anh.FindElement(By.Id("inp$earch"));
                element_search_21_Anh.SendKeys(tuTimKiem_21_Anh);
                Thread.Sleep(1000);
                //Nhấn Enter để tìm kiếm
                element_search_21_Anh.Submit();
                Thread.Sleep(5000);
                // Lấy danh sách sản phẩm hiển thị
                ReadOnlyCollection<IWebElement> list_product_21_Anh = driver_21_Anh.FindElements(By.CssSelector(".product-item h3"));

                // Kiểm tra xem có sản phẩm nào chứa tuTimKiem_21_Anh hay không
                foreach (var product_21_Anh in list_product_21_Anh)
                {
                    //Trả về vị trí xuất hiện tuTimKiem_21_Anh không phân biệt hoa thường
                    if (product_21_Anh.Text.IndexOf(tuTimKiem_21_Anh, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Sản phẩm tồn tại
                        return true; 

                    }
                }

                // Không tìm thấy sản phẩm
                return false; 
            }
            finally
            {
                //Đảm bảo luôn đóng drvier dù cho không tìm được sản phẩm
                driver_21_Anh.Close() ; 
            }
        }
        public void DanhGiaSanPham_21_Anh()
        {
            //Trước khi đánh giá cần phải đăng nhập vào cellphoneS -> không dùng lại DangNhapCellPhoneS_21_Anh(string sđt_21_Anh, string matkhau_21_Anh) vì nó có driver.Close()
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
            driver_21_Anh.FindElement(By.CssSelector("input[type='tel']")).SendKeys("0933033801"); 

            //Lấy element nhập mật khẩu
            driver_21_Anh.FindElement(By.CssSelector("input[type='password']")).SendKeys("tta1301");

            //Lấy element button đăng nhập
            driver_21_Anh.FindElement(By.ClassName("button__login")).Click();

            //Cho web dừng 3s chờ load danh sách các danh mục
            Thread.Sleep(3000);

            //Sau khi đăng nhập ta tiến hành tìm sản phẩm và đánh giá
            driver_21_Anh.FindElement(By.LinkText("Đồ gia dụng")).Click();
            //Web dừng 3s chờ load các sản phẩm
            Thread.Sleep(3000);

            ReadOnlyCollection<IWebElement> list_product_21_Anh = driver_21_Anh.FindElements(By.CssSelector(".product-info"));
            
            //Click vào để vào phần đánh giá của sản phẩm đầu tiên
            list_product_21_Anh[0].Click();

            //đợi load chi tiết sản phẩm
            Thread.Sleep(2000);

            //Click vào nút để nhập nội dung đánh gía
            driver_21_Anh.FindElement(By.XPath("//*[text()='Đánh giá ngay']")).Click();
            
        }
        //Thêm vào giỏ hàng
        public void ThemVaoGioHang_82_Tuyet()
        {
            //Trước khi đánh giá cần phải đăng nhập vào cellphoneS -> không dùng lại DangNhapCellPhoneS_21_Anh(string sđt_21_Anh, string matkhau_21_Anh) vì nó có driver.Close()
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
            driver_21_Anh.FindElement(By.CssSelector("input[type='tel']")).SendKeys("0522194804");

            //Lấy element nhập mật khẩu
            driver_21_Anh.FindElement(By.CssSelector("input[type='password']")).SendKeys("tuyet123");

            //Lấy element button đăng nhập
            driver_21_Anh.FindElement(By.ClassName("button__login")).Click();

            //Cho web dừng 3s chờ load danh sách các danh mục
            Thread.Sleep(3000);

            //Sau khi đăng nhập ta tiến hành thêm sản phẩm vào giỏ hàng
            driver_21_Anh.FindElement(By.LinkText("Điện thoại")).Click();
            //Web dừng 3s chờ load các sản phẩm
            Thread.Sleep(3000);

            ReadOnlyCollection<IWebElement> list_product_82_Tuyet = driver_21_Anh.FindElements(By.CssSelector(".filter-sort__list-product .product-item"));

            //Chọn sản phầm đầu tiên 
            list_product_82_Tuyet[0].Click();

            //đợi load chi tiết sản phẩm
            Thread.Sleep(5000);

            //tắt cửa sổ chat với nhân viên
            IWebElement tatchat_82_Tuyet = driver_21_Anh.FindElement(By.CssSelector(""));
            tatchat_82_Tuyet.Click();

            //Click vào nút để thêm vào giỏ hàng
            IWebElement themvaogio_82_Tuyet=  driver_21_Anh.FindElement(By.CssSelector(".add-to-cart-button"));
            themvaogio_82_Tuyet.Click();


        }

    }
}
