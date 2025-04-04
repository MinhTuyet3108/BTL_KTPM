using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
	[TestClass]
	public class Task3_UnitTest_ReviewsProduct_21_Anh


	{
        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
		public void TC1_DanhGiaSanPham_HienThongbaothanhcong_Pass_21_Anh()
		{
			//Kết quả mong đợi có thông báo thành công -> true
			bool expected_21_Anh = true;
			bool actual_21_Anh = c_21_Anh.DanhGiaSanPham_21_Anh();
			Assert.AreEqual(expected_21_Anh, actual_21_Anh);
		}
		[TestMethod]
		public void TC2_DanhGiaSanPham_HienThongbaothanhcong_Fail_21_Anh()
		{
            //Kết quả mong đợi có không có thông báo thành công mà là thông báo lỗi -> false
            bool expected_21_Anh = false;
            bool actual_21_Anh = c_21_Anh.DanhGiaSanPham_21_Anh();
            Assert.AreEqual(expected_21_Anh, actual_21_Anh);
        }

    }
}
