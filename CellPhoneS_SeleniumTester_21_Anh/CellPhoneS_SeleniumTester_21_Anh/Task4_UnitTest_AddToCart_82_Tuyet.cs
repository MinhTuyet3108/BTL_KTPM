using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
    [TestClass]
    public class Task4_UnitTest_AddToCart_82_Tuyet
    {
        CellPhoneS_Controllers_21_Anh c_82_Tuyet = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
        public void TC1_AddToCart_Pass_82_Tuyet()
        {
            c_82_Tuyet.ThemVaoGioHang_82_Tuyet();
        }
    }
}
