using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhuongTrinhBacHai_21_Anh;

using System;

using System.Data;

namespace PhuongTrinhBacHaiTester_82_Tuyet
{
   
    [TestClass]
    public class UnitTest_PTBacHai_82_Tuyet
    {
        //khai báo tham số trả về
        private double[] Nghiem_82_Tuyet; 
        string Ketqua_82_Tuyet;


        public TestContext TestContext { get; set; }

        //TC1 : a=0.0, b=2.0, c=6.0, ket qua mong doi = {-3.0} -> Pass do kết quả thật sự cũng là {-3.0}
        [TestMethod]
        public void TC1_a_bangkhong_b_c_khackhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0, b_82_Tuyet = 2.0, c_82_Tuyet = 6.0;
            double[] expected_82_Tuyet = { -3.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]

        //TC2 : a=0.0, b=0.0, c=4.0, ket qua mong doi = { } (vô nghiệm) -> Pass do kết quả thật sự cũng là { }

        public void TC2_a_b_bangkhong_c_khackhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0 , b_82_Tuyet = 0.0 , c_82_Tuyet = 4.0;
            double[] expected_82_Tuyet = {};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]

        //TC3 : a=0.0, b=0.0, c=0.0, ket qua mong doi = { } (vô số nghiệm) -> Pass do kết quả thật sự cũng là { }

        public void TC3_a_b_c_bangkhong_Pass_82_Tuyet()
        {
            double a_82_Tuyet = 0.0 , b_82_Tuyet = 0.0 , c_82_Tuyet = 0.0;
            double[] expected_82_Tuyet = {};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }
        [TestMethod]

        //TC4 : a=0.0, b=5.0, c=15.0, ket qua mong doi ={ 4.0} -> Fail do kết quả thật sự là {-3.0}

        public void TC4_a_bangkhong_b_c_khackhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0,  b_82_Tuyet = 5.0 ,  c_82_Tuyet = 15.0;
            double[] expected_82_Tuyet = {4.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]

        //TC5 : a=0.0, b=0.0, c=4.0, ket qua mong doi = { 5.0} -> Fail do kết quả thật sự là { }

        public void TC5_a_b_bangkhong_c_khackhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0, b_82_Tuyet = 0.0 ,c_82_Tuyet = 4.0;


            double[] expected_82_Tuyet = {5.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        [TestMethod]

        //TC6 : a=0.0, b=0.0, c=0.0, ket qua mong doi = {3.0 }  -> Fail do kết quả thật sự là { }

        public void TC6_a_b_c_bangkhong_Fail_82_Tuyet()
        {
            double a_82_Tuyet = 0.0 ,b_82_Tuyet = 0.0 , c_82_Tuyet = 0.0;
            double[] expected_82_Tuyet = {3.0};

            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }
        [TestMethod]

        //TC7 delta_21_Anh =9.0 > 0 , ketquamongdoi = {-2.0 ,-0.5} -> Pass do kết quả thật sự cũng là = {-2.0 ,-0.5}

        public void TC7_delta_lonHonKhong_Pass_21_Anh()
        {
            double a_21_Anh = 2.0 , b_21_Anh = 5.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = {-2.0 ,-0.5};
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet ;
            CollectionAssert.AreEqual(expected_21_Anh , actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");



        }
        [TestMethod]
        //TC8 delta_21_Anh = 0.0  kequamongdoi = {-1.0}  -> Pass do kết quả thật sự cũng là = {-1.0}
        public void TC8_delta_bangKhong_Pass_21_Anh()
        {
            double a_21_Anh = 2.0, b_21_Anh = 4.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = { -1.0 };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");
        }
        [TestMethod]

        //TC9 delta_21_Anh=-8.0 < 0 ketquamongdoi = { }   -> Pass do kết quả thật sự cũng là = { }

        public void TC9_delta_beHonKhong_Pass_21_Anh()
        {
            double a_21_Anh = 3.0, b_21_Anh = 4.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = { };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

        }
        [TestMethod]
        //TC10 delta_21_Anh =4.0 > 0 , ketquamongdoi = { -1.0 ,-2.0} -> Fail do kết quả thật sự là {-1, -0.5}
        public void TC10_delta_lonHonKhong_Fail_21_Anh()
        {
            double a_21_Anh = 4.0, b_21_Anh = 6.0, c_21_Anh = 2.0;
            double[] expected_21_Anh = { -1.0, -2.0 };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

        }
        [TestMethod]

        //TC11 delta_21_Anh = 0.0  kequamongdoi = {1.0}  -> Fail do kết quả thật sự là {2.0}

        public void TC11_delta_bangKhong_Fail_21_Anh()
        {
            double a_21_Anh = 1.0, b_21_Anh = -4.0, c_21_Anh = 4.0;
            double[] expected_21_Anh = { 1.0 };
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");
        }
        [TestMethod]

        //TC12 delta_21_Anh=-3.0 < 0 ketquamongdoi = {x=2.0}   -> Fail do kết quả thật sự là { }

        public void TC12_delta_beHonKhong_Fail_21_Anh()
        {
            double a_21_Anh = 1.0, b_21_Anh = 1.0, c_21_Anh = 1.0;
            double[] expected_21_Anh = {2.0};
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_21_Anh, b_21_Anh, c_21_Anh);
            double[] actual_21_Anh = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_21_Anh, actual_21_Anh, $"Expected: [{string.Join(", ", expected_21_Anh)}], Actual: [{string.Join(", ", actual_21_Anh)}]");

        }


        [TestMethod]

        //TC13 test với dữ liệu csv -> DataSource -> 12 test case -> 6 pass - 6 fail 
        //a,b,c,expected_x1,expected_x2
        //1,-2,1,1,1        -> Pass - Nghiệm kép tại x = 1
        //2,-4,2,1,1        -> Pass - Nghiệm kép tại x = 1
        //1,-3,2,2,1        -> Pass - Hai nghiệm phân biệt tại x1 = 1, x2 = 2
        //2,-8,6,3,1        -> Pass - Hai nghiệm phân biệt tại x1 = 1, x2 = 3
        //1,4,4,-2,-2       -> Pass - Nghiệm kép tại x = -2
        //1,2,5,NULL,NULL   -> Pass - Phương trình vô nghiệm

        //1,2,5,5,5         -> Fail - Vô nghiệm nhưng lại có nghiệm thực không hợp lệ
        //1,-4,4,3,2        -> Fail - Nghiệm phân biệt không khớp, phải là x1 = 2, x2 = 2
        //2,-6,5,5,7        -> Fail - Nghiệm kép nhưng lại trả về x2=7
        //4,-8,4,2,1        -> Fail - Nghiệm kép tại x = 2 nhưng lại có x2 khác 2
        //1,2,3,1,1         -> Fail - Nghiệm phân biệt nhưng lại trả về nghiệm kép tại x = 1
        //1,-3,2,3,1        -> Fail - Hai nghiệm phân biệt nhưng x1 và x2 không đúng

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data_82_Tuyet\TestDataPTBH_82_Tuyet.csv", "TestDataPTBH_82_Tuyet#csv", DataAccessMethod.Sequential)]
        public void TC13_12Testcase_6pass_6fail_82_Tuyet()
        {

            double a_82_Tuyet, b_82_Tuyet, c_82_Tuyet;
            double[] expected_82_Tuyet;


            double.TryParse(TestContext.DataRow[0].ToString(), out a_82_Tuyet);
            double.TryParse(TestContext.DataRow[1].ToString(), out b_82_Tuyet);
            double.TryParse(TestContext.DataRow[2].ToString(), out c_82_Tuyet);

            string x1_str_82_Tuyet = TestContext.DataRow[3].ToString();
            string x2_str_82_Tuyet = TestContext.DataRow[4].ToString();

            if (x1_str_82_Tuyet == "NULL" && x2_str_82_Tuyet == "NULL")
            {
                expected_82_Tuyet = new double[] { };

            }
            else if (x1_str_82_Tuyet == x2_str_82_Tuyet && double.TryParse(x1_str_82_Tuyet, out double x1_82_Tuyet))
            {
          
                expected_82_Tuyet = new double[] { x1_82_Tuyet };
            }
            else if(double.TryParse(x1_str_82_Tuyet, out x1_82_Tuyet)&&double.TryParse(x2_str_82_Tuyet, out double x2_82_Tuyet))
            {
                expected_82_Tuyet = new double[] { x1_82_Tuyet, x2_82_Tuyet };
            }
            else
                expected_82_Tuyet = new double[] {};


            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
            double[] actual_82_Tuyet = Nghiem_82_Tuyet;
            CollectionAssert.AreEqual(expected_82_Tuyet, actual_82_Tuyet, $"Expected: [{string.Join(", ", expected_82_Tuyet)}], Actual: [{string.Join(", ", actual_82_Tuyet)}]");
        }

        //TC14 nhận biết lỗi khi người dùng nhập sai định dạng, a="abc", b="xyz", c="!@#"
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TC14_loiDinhDang_82_Tuyet_Pass()
        {
            // giả lập dữ liệu sai kiểu
            double a_82_Tuyet = double.Parse("abc");
            double b_82_Tuyet = double.Parse("xyz"); 
            double c_82_Tuyet = double.Parse("!@#");
            PhepTinhPhuongTrinhBacHai_21_Anh.GiaiPhuongTrinhBacHai_21_Anh(out Nghiem_82_Tuyet, out Ketqua_82_Tuyet, a_82_Tuyet, b_82_Tuyet, c_82_Tuyet);
        }





 


    }
}
