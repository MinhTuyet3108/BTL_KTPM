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
        //TC1 : a=0.0, b=2.0, c=6.0, ket qua mong doi = {-3.0} -> Pass
        public void TC1_a_bangkhong_b_c_khackhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0, b_82_Tuyet = 2.0, c_82_Tuyet = 6.0;
            double[] expected_82_Tuyet = { -3.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]
        //TC2 : a=0.0, b=0.0, c=4.0, ket qua mong doi = { } (vô nghiệm) -> Pass
        public void TC2_a_b_bangkhong_c_khackhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0 , b_82_Tuyet = 0.0 , c_82_Tuyet = 4.0;
            double[] expected_82_Tuyet = {};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]
        //TC3 : a=0.0, b=0.0, c=0.0, ket qua mong doi = { } (vô số nghiệm) -> Pass
        public void TC3_a_b_c_bangkhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0 , b_82_Tuyet = 0.0 , c_82_Tuyet = 0.0;
            double[] expected_82_Tuyet = {};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }
        [TestMethod]
        //TC4 : a=0.0, b=5.0, c=15.0, ket qua mong doi ={ 4.0} -> Fail
        public void TC4_a_bangkhong_b_c_khackhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0,  b_82_Tuyet = 5.0 ,  c_82_Tuyet = 15.0;
            double[] expected_82_Tuyet = {4.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]
        //TC5 : a=0.0, b=0.0, c=4.0, ket qua mong doi = { 5.0} -> Fail
        public void TC5_a_b_bangkhong_c_khackhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0, b_82_Tuyet = 0.0 ,c_82_Tuyet = 4.0;


            double[] expected_82_Tuyet = {5.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]
        //TC6 : a=0.0, b=0.0, c=0.0, ket qua mong doi = {3.0 }  -> Fail
        public void TC6_a_b_c_bangkhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0 ,b_82_Tuyet = 0.0 , c_82_Tuyet = 0.0;
            double[] expected_82_Tuyet = {3.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }
        [TestMethod]
        //TC7 delta_21_Anh =9.0 > 0 , ketquamongdoi = { -1 ,-2/3} -> Pass
        public void TC7_delta_lonHonKhong_Pass_21_Anh()
        {
            double a_21_Anh = 2.0 , b_21_Anh = 5.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = {-2.0 ,-0.5};
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet ;
            CollectionAssert.AreEqual(expected_21_Anh , actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

            //Xem xét
            //for (int i = 0; i < expected_21_Anh.Length; i++)
            //{
            //    Assert.AreEqual(expected_21_Anh[i], actual_21_Anh[i], 0.0001, "Giá trị nghiệm không đúng"); 0.0001 là sai số chấp nhận đc
            //}
        }
        [TestMethod]
        //TC8 delta_21_Anh = 0.0  kequamongdoi = {-1.0}  -> Pass
        public void TC8_delta_bangKhong_Pass_21_Anh()
        {
            double a_21_Anh = 2.0, b_21_Anh = 4.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = { -1.0 };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");
        }
        [TestMethod]
        //TC9 delta_21_Anh=-8.0 < 0 ketquamongdoi = { }   -> Pass
        public void TC9_delta_beHonKhong_Pass_21_Anh()
        {
            double a_21_Anh = 3.0, b_21_Anh = 4.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = { };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

        }
        [TestMethod]
        //TC10 delta_21_Anh =4.0 > 0 , ketquamongdoi = { -1.0 ,-2.0} -> Fail
        public void TC10_delta_lonHonKhong_Fail_21_Anh()
        {
            double a_21_Anh = 4.0, b_21_Anh = 6.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = { -1.0, -2.0 };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

        }
        [TestMethod]
        //TC11 delta_21_Anh = 0.0  kequamongdoi = {1.0}  -> Fail
        public void TC11_delta_bangKhong_Fail_21_Anh()
        {
            double a_21_Anh = 1.0, b_21_Anh = -4.0, c_21_Anh = 4.0;
            double[] expected_21_Anh = { 1.0 };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");
        }
        [TestMethod]
        //TC12 delta_21_Anh=-3.0 < 0 ketquamongdoi = {x=2.0}   -> Fail
        public void TC12_delta_beHonKhong_Fail_21_Anh()
        {
            double a_21_Anh = 1.0, b_21_Anh = 1.0, c_21_Anh = 1.0;
            double[] expected_21_Anh = {2.0};
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

        }
        //TC13 -> DataSource -> 12 test case -> 6 pass - 6 fail 
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestPower.csv", "TestPower#csv", DataAccessMethod.Sequential)]
        public void TC13_12Testcase_6pass_6fail_82_Tuyet()
        {

        }

    }
}
