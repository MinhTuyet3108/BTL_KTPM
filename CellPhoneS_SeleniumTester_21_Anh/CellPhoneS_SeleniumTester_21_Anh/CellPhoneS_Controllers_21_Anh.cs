using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.BiDi.Modules.Script.EvaluateResult;





namespace CellPhoneS_SeleniumTester_21_Anh
{
    class CellPhoneS_Controllers_21_Anh
    {
        //Tạo ra đối tượng Driver
        IWebDriver driver_21_Anh = new ChromeDriver();

        IWebDriver driver_82_Tuyet = new ChromeDriver();

        //Phương thức truy cập trang chủ
        public void TruyCapTrangChu_21_Anh()
        {

            driver_21_Anh.Navigate().GoToUrl("https://cellphones.com.vn/");
        }

        public void TruyCapTrangChu_82_Tuyet()
        {
            driver_82_Tuyet.Navigate().GoToUrl("https://cellphones.com.vn/");
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

            driver_21_Anh.Quit();

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
                driver_21_Anh.Quit();
            }
        }
        public bool DanhGiaSanPham_21_Anh()
        {
            try
            {
                //Trước khi đánh giá cần phải đăng nhập vào cellphoneS -> không dùng lại DangNhapCellPhoneS_21_Anh(string sđt_21_Anh, string matkhau_21_Anh) vì nó có driver.Close()
                TruyCapTrangChu_21_Anh();

                //Đăng nhập///////


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

                //////////////////////////////////


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

                //Đợi load form đánh giá
                Thread.Sleep(2000);

                //Nhập nội dung đánh giá
                driver_21_Anh.FindElement(By.CssSelector(".textarea")).SendKeys("Đánh giá tốt 21_Anh");

                //Chọn mức độ cho đánh giá chung 
                ReadOnlyCollection<IWebElement> danhgiachung_21_Anh = driver_21_Anh.FindElements(By.CssSelector(".star-all .icon"));
                //Cho đánh giá chung 4 sao
                danhgiachung_21_Anh[3].Click();
                //Cho đánh giá theo trải nghiệm 4 sao
                ReadOnlyCollection<IWebElement> danhtheotrainghiem_21_Anh = driver_21_Anh.FindElements(By.CssSelector(".star .icon"));
                danhtheotrainghiem_21_Anh[3].Click();


                //Gửi ảnh lên đánh giá
                driver_21_Anh.FindElement(By.CssSelector("#image")).SendKeys(@"D:\21_Anh.png");

                //Nhấn để gửi đánh giá
                driver_21_Anh.FindElement(By.CssSelector("button.modal__button.has-text-white")).Click();


                Thread.Sleep(1000);
                //Lấy element thông báo thành công xem có được hiển thị hay không -> nếu có là đánh giá đã thành công
                IWebElement thongbaothanhcong_21_Anh = driver_21_Anh.FindElement(By.CssSelector(".toasted.toasted-primary.success"));
                if (thongbaothanhcong_21_Anh.Displayed)
                {
                    return true;
                }
                return false;
            }

            finally
            {
                //Đảm bảo luôn đóng drvier dù cho không tìm được sản phẩm
                driver_21_Anh.Quit();
            }




        }
        //Thêm vào giỏ hàng
        public bool ThemVaoGioHang_82_Tuyet()
        {

            try
            {
                //Trước khi đánh giá cần phải đăng nhập vào cellphoneS -> không dùng lại DangNhapCellPhoneS_21_Anh(string sđt_21_Anh, string matkhau_21_Anh) vì nó có driver.Close()
                TruyCapTrangChu_82_Tuyet();

                // cho web dừng 2s để load trang chủ
                Thread.Sleep(2000);
                //Click vào để vào đăng nhập
                driver_82_Tuyet.FindElement(By.ClassName("login-btn")).Click();
                // cho web dừng 2s để load nút đăng nhập
                Thread.Sleep(2000);
                //Click chuyển tới trang đăng nhập
                driver_82_Tuyet.FindElement(By.CssSelector(".modal-login .login-btn")).Click();


                //Lấy element nhập số điện thoại
                driver_82_Tuyet.FindElement(By.CssSelector("input[type='tel']")).SendKeys("0522194804");

                //Lấy element nhập mật khẩu
                driver_82_Tuyet.FindElement(By.CssSelector("input[type='password']")).SendKeys("tuyet000");

                //Lấy element button đăng nhập
                driver_82_Tuyet.FindElement(By.ClassName("button__login")).Click();

                //Cho web dừng 3s chờ load danh sách các danh mục
                Thread.Sleep(3000);

                //Sau khi đăng nhập ta tiến hành thêm sản phẩm vào giỏ hàng
                driver_82_Tuyet.FindElement(By.LinkText("Điện thoại")).Click();
                //Web dừng 3s chờ load các sản phẩm
                Thread.Sleep(3000);

                ReadOnlyCollection<IWebElement> list_product_82_Tuyet = driver_82_Tuyet.FindElements(By.CssSelector(".filter-sort__list-product .product-item"));

                //Chọn sản phầm đầu tiên 
                list_product_82_Tuyet[0].Click();

<<<<<<< Updated upstream



            //Click vào nút để thêm vào giỏ hàng
            IWebElement themvaogio_82_Tuyet =  driver_21_Anh.FindElement(By.CssSelector(".add-to-cart-button"));
            themvaogio_82_Tuyet.Click();
=======
                //Click vào nút để thêm vào giỏ hàng
                IWebElement themvaogio_82_Tuyet = driver_82_Tuyet.FindElement(By.CssSelector(".add-to-cart-button"));
                themvaogio_82_Tuyet.Click();

                Thread.Sleep(1000);

                //Lấy element thông báo thành công xem có được hiển thị hay không -> nếu có thì đã thêm vào giỏ thành công
                IWebElement themthanhcong_82_Tuyet = driver_82_Tuyet.FindElement(By.CssSelector(".toasted.toasted-primary.success"));
                if (themthanhcong_82_Tuyet.Displayed)
                {
                    return true;
                }
                return false;
            }
>>>>>>> Stashed changes

            finally
            {
                //đóng cửa sổ sau khi thêm vào giỏ hàng
                driver_82_Tuyet.Quit();
            }

        }
        public string TimKiemCuaHang_82_Tuyet()
        {

<<<<<<< Updated upstream


        public string KiemTraLichSuMuaHang_21_Anh()
        {
            try
            {
                TruyCapTrangChu_21_Anh();






                //Đăng nhập///////


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

                //////////////////////////////////


                //Lấy element smember và Click vào
                driver_21_Anh.FindElement(By.CssSelector(".smember")).Click();
                //Lấy element truy cập smember và Click vào
                driver_21_Anh.FindElement(By.ClassName("noti-head")).Click();
                //Chờ web load 1s 
                Thread.Sleep(1000);
                //Lấy element lịch sử mua hàng và Click vào
                driver_21_Anh.FindElement(By.XPath("//*[text()='Lịch sử mua hàng']")).Click();
                //Chờ web load 1s 
                Thread.Sleep(1000);
                //Lấy element xem chi tiết 
                driver_21_Anh.FindElement(By.XPath("//*[text()='Xem chi tiết']")).Click();
                //Chờ web load 1s 
                Thread.Sleep(1000);
                //Lấy element đơn hàng để lấy được mã đơn 
                IWebElement donhang_21_Anh = driver_21_Anh.FindElement(By.CssSelector(".code__name strong"));
                string madon_21_Anh = donhang_21_Anh.Text;
                return madon_21_Anh;
            }
            finally
            {
                driver_21_Anh.Close();
            }
 
        }

=======
            try
            {
                //truy cập vào trang chủ trước khi tìm kiếm cửa hàng
                TruyCapTrangChu_82_Tuyet();

                // cho web dừng 2s để load trang chủ
                Thread.Sleep(2000);

                //Click vào để vào chức năng tìm kiếm cửa hàng
                driver_82_Tuyet.FindElement(By.ClassName("button__link-address")).Click();
                // cho web dừng 5s để load 
                Thread.Sleep(5000);

                //Sau khi web load xong ta tiến hành tìm cửa hàng gần với vị trí của mình
                SelectElement tinh_82_Tuyet = new SelectElement(driver_82_Tuyet.FindElement(By.Id("boxSearchProvince")));
                tinh_82_Tuyet.SelectByValue("30");

                Thread.Sleep(1000);

                SelectElement quanhuyen_82_Tuyet = new SelectElement(driver_82_Tuyet.FindElement(By.Id("boxSearchDistrict")));
                quanhuyen_82_Tuyet.SelectByValue("16");

                ////load danh sách địa chỉ
                //ReadOnlyCollection<IWebElement> list_address_82_Tuyet = driver_82_Tuyet.FindElements(By.CssSelector("boxSearch-result-item"));

                ////Chọn địa chỉ đầu tiên 
                //list_address_82_Tuyet[0].Click();

                //load danh sách cửa hàng ở gần địa chỉ vừa tìm
                ReadOnlyCollection<IWebElement> list_shop_82_Tuyet = driver_82_Tuyet.FindElements(By.ClassName("boxMap-store"));
                string name_store = list_shop_82_Tuyet[0].Text;
                return name_store;


            }
            finally
            {
                //đóng cửa sổ sau khi thêm vào giỏ hàng
                driver_82_Tuyet.Quit();
            }

        }
>>>>>>> Stashed changes
    }
}
