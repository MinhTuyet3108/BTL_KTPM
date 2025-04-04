﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CellPhoneS_SeleniumTester_21_Anh
{

    [TestClass]
    public class Task2_UnitTest_SearchProduct_21_Anh
    {
        
        CellPhoneS_Controllers_21_Anh c_21_Anh = new CellPhoneS_Controllers_21_Anh();

        //TC1 tuTimKiem_21_Anh = "Iphone 16" , expected_21_Anh=true , actual_21_Anh = true -> Pass do khi tìm thấy sản phẩm kết quả thật sự là true đúng với kết quả mong đợi là true
        [TestMethod]
        public void TC1_SearchProduct_Find_Pass_21_Anh()
        {
            string tuTimKiem_21_Anh = "Iphone 16";

            // Gọi hàm tìm kiếm và kiểm tra kết quả
            bool actual_21_Anh = c_21_Anh.TimKiemSanPham_21_Anh(tuTimKiem_21_Anh);
            bool expected_21_Anh = true;
            Assert.AreEqual(expected_21_Anh, actual_21_Anh);
            
        }
        //TC2 tuTimKiem_21_Anh = "@@" , expected_21_Anh=true , actual_21_Anh = fail -> Fail khi không tìm thấy sản phẩm kết quả thật sự là false nhưng kết quả mong đợi là lại true
        [TestMethod]
        public void TC2_SearchProduct_notFound_Fail_21_Anh()
        {
            string tuTimKiem_21_Anh = "@@";
            bool actual_21_Anh = c_21_Anh.TimKiemSanPham_21_Anh(tuTimKiem_21_Anh);
            //Không tìm thấy thì phải trả ra false theo logic của dev .
            bool expected_21_Anh = true;
            Assert.AreEqual(expected_21_Anh , actual_21_Anh);
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
