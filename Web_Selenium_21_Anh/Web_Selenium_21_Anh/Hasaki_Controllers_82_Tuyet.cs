using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography;

namespace Web_Selenium_21_Anh
{
    public class Hasaki_Controllers_82_Tuyet
    {
        //Tạo ra đối tượng Driver
        IWebDriver driver_82_Tuyet;

        //Phương thức truy cập trang chủ
        public void TruyCapTrangChu_82_Tuyet()
        {
            //Tắt màn hình đen khi chạy
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            driver_82_Tuyet = new ChromeDriver(chrome);
            //truy cập liên kết tới hasaki
            driver_82_Tuyet.Navigate().GoToUrl("https://hasaki.vn/");
            //mở trình duyệt với độ lớn tối đa
            driver_82_Tuyet.Manage().Window.Maximize();
        }
        //Chức năng đăng nhập
        public void DangNhapHasaki_82_Tuyet(string username_82_Tuyet, string password_82_Tuyet)
        {
            try
            {
                TruyCapTrangChu_82_Tuyet();
                // cho web dừng 2s để load trang chủ
                Thread.Sleep(2000);
                //đóng pop up che nút đăng nhập
                driver_82_Tuyet.FindElement(By.Id("onesignal-slidedown-cancel-button")).Click();
                //Click vào để vào đăng nhập
                driver_82_Tuyet.FindElement(By.LinkText("Đăng nhập")).Click();
                // cho web dừng 2s để load 
                Thread.Sleep(2000);

                //Lấy element nhập số điện thoại
                IWebElement element_username_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("username"));
                //Gửi số điện thoại 
                element_username_82_Tuyet.SendKeys(username_82_Tuyet);
                //Lấy element nhập mật khẩu
                IWebElement element_password_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("password"));
                //Gửi mật khẩu  
                element_password_82_Tuyet.SendKeys(password_82_Tuyet);
                //Lấy element button đăng nhập
                IWebElement element_dangnhap_82_Tuyet = driver_82_Tuyet.FindElement(By.ClassName("btn_site_1"));
                element_dangnhap_82_Tuyet.Click();

                //lấy element user
                IWebElement element_user_82_Tuyet = driver_82_Tuyet.FindElement(By.CssSelector(".item_header.item_login.user_login"));

                // Tạo đối tượng Actions
                Actions action_82_Tuyet = new Actions(driver_82_Tuyet);

                // Di chuột đến element user để hiện lựa chọn
                action_82_Tuyet.MoveToElement(element_user_82_Tuyet).Perform();

                //Click chọn truy vập vào tài khoản
                driver_82_Tuyet.FindElement(By.ClassName("fa-file-text-o")).Click();

                Thread.Sleep(2000);

                IWebElement element_ten_82_Tuyet = driver_82_Tuyet.FindElement(By.ClassName("name_account"));
                IWebElement element_sdt_82_Tuyet = driver_82_Tuyet.FindElement(By.ClassName("email_account"));
                string ten_82_Tuyet = element_ten_82_Tuyet.Text;
                string sdt_82_Tuyet = element_sdt_82_Tuyet.Text;
                Console.WriteLine("Ten nguoi dung la " + ten_82_Tuyet + " va so dien thoai la " + sdt_82_Tuyet);
            }
            finally
            {
                driver_82_Tuyet.Close();
            }
        }

        //Chức năng Tìm kiếm tên sản phẩm
        public void TimKiem_82_Tuyet(string word_82_Tuyet)
        {
            try
            {
                TruyCapTrangChu_82_Tuyet();
                //Dừng 2s để chờ web load
                Thread.Sleep(2000);
                // Tìm ô tìm kiếm và nhập từ khóa
                IWebElement element_search_82_Tuyet = driver_82_Tuyet.FindElement(By.XPath("//*[@id='search']"));
                element_search_82_Tuyet.SendKeys(word_82_Tuyet);
                Thread.Sleep(1000);
                //Nhấn Enter để tìm kiếm
                element_search_82_Tuyet.Submit();
                Thread.Sleep(5000);
                // Lấy danh sách sản phẩm hiển thị
                ReadOnlyCollection<IWebElement> list_product82_Tuyet = driver_82_Tuyet.FindElements(By.CssSelector(".ProductGridItem__itemOuter"));

                //Lấy 10 sản phẩm đầu trong danh sách các sản phẩm
                foreach (var item_82_Tuyet in list_product82_Tuyet.Take(10))
                {
                    //Lấy tên sản phẩm, thương hiệu và giá
                    string tensanpham_82_Tuyet = item_82_Tuyet.FindElement(By.CssSelector("h2")).Text;
                    string thuonghieu_82_Tuyet = item_82_Tuyet.FindElement(By.CssSelector(".width_common.txt_color_1.space_bottom_3")).Text;
                    string gia_82_Tuyet = item_82_Tuyet.FindElement(By.CssSelector(".item_giamoi.txt_16")).Text;
                    Console.WriteLine("Tên Sản Phẩm: " + tensanpham_82_Tuyet + " - Thuong hieu: " + thuonghieu_82_Tuyet + " - Giá: " + gia_82_Tuyet);
                }

            }
            finally
            {
                //Đảm bảo luôn đóng drvier dù cho không tìm được sản phẩm
                driver_82_Tuyet.Close();
            }
        }

        //Chức năng Thêm sản phẩm vào giỏ hàng
        public void Themvaogiohang_82_Tuyet()
        {
            try
            {
                TruyCapTrangChu_82_Tuyet();
                // cho web dừng 2s để load trang chủ
                Thread.Sleep(2000);
                //tắt pop up
                driver_82_Tuyet.FindElement(By.Id("onesignal-slidedown-cancel-button")).Click();
                //Không sử dùng lại chức năng đăng nhập vì có driver_82_Tuyet.Close()
                //Click vào để vào đăng nhập
                driver_82_Tuyet.FindElement(By.LinkText("Đăng nhập")).Click();
                // cho web dừng 2s để load 
                Thread.Sleep(2000);

                //Lấy element nhập số điện thoại
                IWebElement element_username_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("username"));
                //Gửi số điện thoại 
                element_username_82_Tuyet.SendKeys("0522194804");
                //Lấy element nhập mật khẩu
                IWebElement element_password_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("password"));
                //Gửi mật khẩu  
                element_password_82_Tuyet.SendKeys("33225566");
                //Lấy element button đăng nhập
                IWebElement element_dangnhap_82_Tuyet = driver_82_Tuyet.FindElement(By.ClassName("btn_site_1"));
                element_dangnhap_82_Tuyet.Click();

                //lấy element để chọn danh mục sản phẩm 
                IWebElement element_danhmuc_82_Tuyet = driver_82_Tuyet.FindElement(By.LinkText("DANH MỤC"));

                // Tạo đối tượng Actions để rê chuột vào danh mục
                Actions action_82_Tuyet = new Actions(driver_82_Tuyet);

                // Di chuột đến element user để hiện lựa chọn
                action_82_Tuyet.MoveToElement(element_danhmuc_82_Tuyet).Perform();

                //Click chọn truy vập vào 
                driver_82_Tuyet.FindElement(By.LinkText("Trang Điểm")).Click();
                //Ngủ 2s để load danh sách sản phẩm
                Thread.Sleep(2000);
                // Lấy danh sách sản phẩm hiển thị
                ReadOnlyCollection<IWebElement> list_sp_82_Tuyet = driver_82_Tuyet.FindElements(By.CssSelector(".ProductGridItem__itemOuter"));
                //Chọn sản phầm đầu tiên
                list_sp_82_Tuyet[0].Click();
                //Ngủ 2s để load sản phẩm
                Thread.Sleep(2000);
                //lấy element thêm vào giỏ
                driver_82_Tuyet.FindElement(By.XPath("//button[.//span[@class='sr-only' and contains(text(),'Cart plus icon')]]")).Click();
                //ngủ 1s để hiện thông báo thêm thành công
                Thread.Sleep(1000);
                //Lấy element thông báo thành công 
                IWebElement thongbaothanhcong_21_Anh = driver_82_Tuyet.FindElement(By.CssSelector("div.text-sm.opacity-100"));
                //in nội dung thông báo ra output
                string noidungthongbao_21_Anh = thongbaothanhcong_21_Anh.Text;
                Console.WriteLine("Nội dung thông báo: " + noidungthongbao_21_Anh);

            }
            finally
            {
                driver_82_Tuyet.Close();
            }
        }

        //Chức năng đổi mật khẩu
        public void Doimatkhau_82_Tuyet()
        {
            try 
            { 

            TruyCapTrangChu_82_Tuyet();
            // cho web dừng 2s để load trang chủ
            Thread.Sleep(2000);
            //tắt pop up
            driver_82_Tuyet.FindElement(By.Id("onesignal-slidedown-cancel-button")).Click();
            //Không sử dùng lại chức năng đăng nhập vì có driver_82_Tuyet.Close()
            //Click vào để vào đăng nhập
            driver_82_Tuyet.FindElement(By.LinkText("Đăng nhập")).Click();
            // cho web dừng 2s để load 
            Thread.Sleep(2000);

            //Lấy element nhập số điện thoại
            IWebElement element_username_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("username"));
            //Gửi số điện thoại 
            element_username_82_Tuyet.SendKeys("0522194804");
            //Lấy element nhập mật khẩu
            IWebElement element_password_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("password"));
            //Gửi mật khẩu 
            element_password_82_Tuyet.SendKeys("33225566");

            //Lấy element button đăng nhập
            IWebElement element_dangnhap_82_Tuyet = driver_82_Tuyet.FindElement(By.ClassName("btn_site_1"));
            element_dangnhap_82_Tuyet.Click();

            //lấy element để chọn Tài khoản 
            IWebElement element_tk_82_Tuyet = driver_82_Tuyet.FindElement(By.LinkText("Tài khoản"));

            // Tạo đối tượng Actions để rê chuột vào danh mục
            Actions act_tk_82_Tuyet = new Actions(driver_82_Tuyet);

            // Di chuột đến element user để hiện lựa chọn
            act_tk_82_Tuyet.MoveToElement(element_tk_82_Tuyet).Perform();

            //Click chọn truy vập vào trang tài khoản
            driver_82_Tuyet.FindElement(By.LinkText("Tài khoản của bạn")).Click();
            //Ngủ 1s để load 
            Thread.Sleep(1000);

            //Click vào thông tin tài khoản
            driver_82_Tuyet.FindElement(By.CssSelector("a[href='https://hasaki.vn/customer/account/edit']")).Click();
            //Ngủ 1s để load 
            Thread.Sleep(1000);

            //Lấy element đổi mật khẩu
            driver_82_Tuyet.FindElement(By.XPath("//div[contains(@class, 'item_subinfo_account') and contains(., 'Đổi mật khẩu')]//a[contains(text(), 'Cập nhật')]")).Click();
            //Element nhập mật khẩu hiện tại
            IWebElement mk_hientai_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("password"));
            mk_hientai_82_Tuyet.SendKeys("33225566");
            //element nhập mật khẩu mới
            IWebElement mk_moi_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("passwordNew"));
            mk_moi_82_Tuyet.SendKeys("12341234");
            //element nhập xác nhận mật khẩu mới
            IWebElement xacnhan_mkmoi_82_Tuyet = driver_82_Tuyet.FindElement(By.Id("passwordConfirm"));
            xacnhan_mkmoi_82_Tuyet.SendKeys("12341234");

            //lấy element button cập nhật đổi mật khẩu
            driver_82_Tuyet.FindElement(By.XPath("//button[@type='submit' and contains(@class, 'btn_site_1')]")).Click();

            //lấy url sau khi cập nhật mật khẩu thành công
            string urlhientai_82_Tuyet = driver_82_Tuyet.Url;
            Console.WriteLine("Trang web hiện tại: " + urlhientai_82_Tuyet);

        } 
            finally
            {
                driver_82_Tuyet.Close();
            }
}
    }
}
