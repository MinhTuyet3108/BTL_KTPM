using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
	[TestClass]
	public class Task5_UnitTest_ViewHistory_21_Anh
	{
	

		CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
        public void TC1_LichSuMuaHang_Fail_21_Anh()
		{
            //kết quả mong đợi có mã đơn hàng abc213sdasd -> Test case fail do mã đơn thật sự là WN0302761684
            string expected_21_Anh = "abc213sdasd";
			string actual_21_Anh = c_21_Anh.KiemTraLichSuMuaHang_21_Anh();
			Assert.AreEqual(expected_21_Anh, actual_21_Anh);
		}
        [TestMethod]
        public void TC2_LichSuMuaHang_Pass_21_Anh()
        {
            //kết quả mong đợi có mã đơn hàng  WN0302761684-> Test case pass do mã đơn thật là WN0302761684
            string expected_21_Anh = "WN0302761684";
            string actual_21_Anh = c_21_Anh.KiemTraLichSuMuaHang_21_Anh();
            Assert.AreEqual(expected_21_Anh, actual_21_Anh);
        }
    }
}
