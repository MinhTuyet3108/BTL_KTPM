using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
    [TestClass]
    public class Task4_UnitTest_AddToCart_82_Tuyet
    {
        CellPhoneS_Controllers_21_Anh c_82_Tuyet = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
        public void TC1_ThemVaoGioHang_ThongBaoThanhCong_Pass_82_Tuyet()
        {
            //Kết quả mong đợi có thông báo thành công -> true
            bool expected_82_Tuyet = true;
            bool actual_82_Tuyet = c_82_Tuyet.ThemVaoGioHang_82_Tuyet();
            Assert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }
        [TestMethod]
        public void TC2_ThemVaoGioHang_ThongBaoThanhCong_Fail_82_Tuyet()
        {
            //Kết quả mong đợi có không có thông báo thành công mà là thông báo lỗi -> false
            bool expected_82_Tuyet = false;
            bool actual_82_Tuyet = c_82_Tuyet.ThemVaoGioHang_82_Tuyet();
            Assert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }
    }
}
