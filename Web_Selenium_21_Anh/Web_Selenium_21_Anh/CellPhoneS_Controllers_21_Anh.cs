using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Web_Selenium_21_Anh
{


    class CellPhoneS_Controllers_21_Anh
    {


        //Tạo ra đối tượng Driver
        IWebDriver driver_21_Anh;

        //Phương thức truy cập trang chủ
        public void TruyCapTrangChu_21_Anh()
        {
            //Tắt màn hình đen khi chạy
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            driver_21_Anh = new ChromeDriver(chrome);

            driver_21_Anh.Navigate().GoToUrl("https://cellphones.com.vn/");

        }

        public void DangNhapCellPhoneS_21_Anh(string sđt_21_Anh, string matkhau_21_Anh)
        {
            try
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

                Thread.Sleep(2000);
                //Lấy element smember và Click vào
                driver_21_Anh.FindElement(By.CssSelector(".smember")).Click();
                //Lấy element truy cập smember và Click vào
                driver_21_Anh.FindElement(By.ClassName("noti-head")).Click();
                //Chờ web load 3s 
                Thread.Sleep(3000);

                IWebElement name_21_Anh = driver_21_Anh.FindElement(By.CssSelector(".welcome-smember__name"));

                string tennguoidung_21_Anh = name_21_Anh.Text;

                Console.WriteLine("Tên người dùng là " + tennguoidung_21_Anh);
            }
            finally
            {
                driver_21_Anh.Close();
            }
        }


            public void TimKiemSanPham_21_Anh(string tuTimKiem_21_Anh)
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
                ReadOnlyCollection<IWebElement> list_product_21_Anh = driver_21_Anh.FindElements(By.CssSelector(".product-item"));

                //Chỉ lấy 5 sản phẩm đầu tiền trong danh sách các sản phẩm
                foreach(var item_21_Anh in list_product_21_Anh.Take(5))
                {
                    //Sẽ lấy tên và giá
                    string tensp_21_Anh = item_21_Anh.FindElement(By.CssSelector("h3")).Text;
                    string gia_21_Anh  = item_21_Anh.FindElement(By.CssSelector(".product__price--show")).Text;
                    Console.WriteLine("Tên Sản Phẩm" + tensp_21_Anh + "Gía sản phẩm" + gia_21_Anh);
                }


            }
            finally
            {
                //Đảm bảo luôn đóng drvier dù cho không tìm được sản phẩm
                driver_21_Anh.Close();
            }
        }
    


        /// 
        /// Chưa fixx
        /// 
     public void DanhGiaSanPham_21_Anh()
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
                driver_21_Anh.FindElement(By.CssSelector("input[type='tel']")).SendKeys("0522194804");



                //Lấy element nhập mật khẩu
                driver_21_Anh.FindElement(By.CssSelector("input[type='password']")).SendKeys("tuyet000");

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


                Thread.Sleep(2000);
                //Lấy element thông báo thành công xem có được hiển thị hay không -> nếu có là đánh giá đã thành công
                IWebElement thongbaothanhcong_21_Anh = driver_21_Anh.FindElement(By.CssSelector(".toasted.toasted-primary.success"));
            }

            finally
            {
                driver_21_Anh.Close();
            }




        }

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


    }

}

