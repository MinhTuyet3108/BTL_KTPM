using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{

    [TestClass]
    public class Task2_UnitTest_SearchProduct_21_Anh
    {

        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();
        [TestMethod]
        public void TC1_SearchProduct_Pass_21_Anh()
        {
            string tuTimKiem_21_Anh = "Iphone 16";

            // Gọi hàm tìm kiếm và kiểm tra kết quả
            bool actual_21_Anh = c_21_Anh.TimKiemSanPham_21_Anh(tuTimKiem_21_Anh);
            bool expected_21_Anh = true;
            Assert.AreEqual(expected_21_Anh, actual_21_Anh);
            
        }



        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion



    }
}
