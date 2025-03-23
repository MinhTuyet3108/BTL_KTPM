using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhuongTrinhBacHai_21_Anh;
using System;

namespace PhuongTrinhBacHaiTester_82_Tuyet
{
   
    [TestClass]
    public class UnitTest_PTBacHai_82_Tuyet
    {
        //khai báo tham số trả về
        private double[] Nghiem_82_Tuyet; 
        string Ketqua_82_Tuyet;

        [TestMethod]
        //TC1 : a=0.0, b=2.0, c=6.0, ket qua mong doi = {-3.0}
        public void TC1_a_bangkhong_b_c_khackhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0;
            double b_82_Tuyet = 2.0;
            double c_82_Tuyet = 6.0;
            double[] expected_82_Tuyet = { -3.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }

        [TestMethod]
        //TC2 : a=0.0, b=0.0, c=4.0, ket qua mong doi = { } (vô nghiệm)
        public void TC2_a_b_bangkhong_c_khackhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0;
            double b_82_Tuyet = 0.0;
            double c_82_Tuyet = 4.0;
            double[] expected_82_Tuyet = {};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }

        [TestMethod]
        //TC3 : a=0.0, b=0.0, c=0.0, ket qua mong doi = { } (vô số nghiệm)
        public void TC3_a_b_c_bangkhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0;
            double b_82_Tuyet = 0.0;
            double c_82_Tuyet = 0.0;
            double[] expected_82_Tuyet = {};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }
        [TestMethod]
        //TC4 : a=0.0, b=5.0, c=15.0, ket qua mong doi ={ 4.0}
        public void TC4_a_bangkhong_b_c_khackhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0;
            double b_82_Tuyet = 5.0;
            double c_82_Tuyet = 15.0;
            double[] expected_82_Tuyet = {4.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }

        [TestMethod]
        //TC5 : a=0.0, b=0.0, c=4.0, ket qua mong doi = { 5.0}
        public void TC5_a_b_bangkhong_c_khackhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0;
            double b_82_Tuyet = 0.0;
            double c_82_Tuyet = 4.0;
            double[] expected_82_Tuyet = {5.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }

        [TestMethod]
        //TC6 : a=0.0, b=0.0, c=0.0, ket qua mong doi = {3.0 } 
        public void TC6_a_b_c_bangkhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0;
            double b_82_Tuyet = 0.0;
            double c_82_Tuyet = 0.0;
            double[] expected_82_Tuyet = {3.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet);
        }
    }
}
