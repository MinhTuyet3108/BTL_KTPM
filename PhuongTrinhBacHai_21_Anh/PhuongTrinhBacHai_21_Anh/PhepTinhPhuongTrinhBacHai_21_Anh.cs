﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBacHai_21_Anh
{
    public class PhepTinhPhuongTrinhBacHai_21_Anh // sửa internal thành public để có thể gọi class này ở project unit test (project khác)
    {
        //Dùng out parameter để xử lý riêng bên form và bên tester
        public static void GiaiPhuongTrinhBacHai_21_Anh(out double[] Nghiem_21_Anh , out string KetQua_21_Anh ,  double a_21_Anh, double b_21_Anh, double c_21_Anh) // dùng static để không cần tạo mới đối tượng ( new GiaiPhuongTrinhBacHai_21_Anh(a,b,c))
        {
            if (a_21_Anh == 0)
            {
                if ( b_21_Anh== 0)
                {
                    KetQua_21_Anh = (c_21_Anh == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                    Nghiem_21_Anh = new double[]{};
                }
                else
                {

                    double x_21_Anh = -c_21_Anh / b_21_Anh;
                    KetQua_21_Anh = String.Format("Phương trình có một nghiệm x = {0:F2}", x_21_Anh);
                    Nghiem_21_Anh = new double[] {x_21_Anh};
                
                }

            }
            else
            {
                double delta_21_Anh = b_21_Anh *b_21_Anh -4 *a_21_Anh * c_21_Anh;
                if (delta_21_Anh > 0)
                {
                    double x1_21_Anh = (-b_21_Anh - Math.Sqrt(delta_21_Anh)) / (2 * a_21_Anh);
                    double x2_21_Anh = (-b_21_Anh + Math.Sqrt(delta_21_Anh)) / (2 * a_21_Anh);
                    KetQua_21_Anh = String.Format("Phương trình có hai nghiệm phân biệt x1 = {0:F2} , x2 = {1:F2}", x1_21_Anh, x2_21_Anh);
                    Nghiem_21_Anh = new double[] {x1_21_Anh,x2_21_Anh };

                }
                else if (delta_21_Anh == 0)
                {
                    double x_21_Anh = -b_21_Anh/(2 * a_21_Anh);
                    KetQua_21_Anh = String.Format("Phương trình có nghiệm kép : x = {0:F2}", x_21_Anh);
                    Nghiem_21_Anh = new double[] { x_21_Anh };


                }
                else // delta_21_Anh < 0 
                {
                    KetQua_21_Anh = "Phương trình vô nghiệm";
                    Nghiem_21_Anh = new double[] { };
                }
            }
        }
    }
}