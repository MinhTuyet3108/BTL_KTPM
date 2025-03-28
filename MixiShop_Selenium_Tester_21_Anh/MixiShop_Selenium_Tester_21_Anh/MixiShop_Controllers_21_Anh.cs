using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Thêm dòng này để làm việc với Selenium
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MixiShop_Selenium_Tester_21_Anh
{
    class MixiShop_Controllers_21_Anh // không sửa public cũng được 
    {
        public void TruyCapTrangChu_21_Anh () { 
            IWebDriver driver_21_Anh = new ChromeDriver ();
            driver_21_Anh.Navigate().GoToUrl("https://shop.mixigaming.com/");
        }
        public void DangNhapMixiShop_21_Anh(string email_21_Anh , string matkhau_21_Anh)
        {

        }
    }
}
