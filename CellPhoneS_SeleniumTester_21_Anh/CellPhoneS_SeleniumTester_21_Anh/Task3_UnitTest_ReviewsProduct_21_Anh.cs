using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
	[TestClass]
	public class Task3_UnitTest_ReviewsProduct_21_Anh


	{
        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
		public void TC1_DanhGiaSanPham_thanhcong_21_Anh()
		{
			c_21_Anh.DanhGiaSanPham_21_Anh();
		}
	}
}
