using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{
    [TestClass]
    public class Task6_UnitTest_FindStore_82_Tuyet
    {
        CellPhoneS_Controllers_21_Anh c_82_Tuyet = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
        public void TC1_TimKiemCuaHang_Pass_82_Tuyet()
        {
            string expected_82_Tuyet = "123";
            string actual_82_Tuyet = c_82_Tuyet.TimKiemCuaHang_82_Tuyet();
            Assert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }
    }
}
