using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
     class HinhTamGiac : Hinh
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public HinhTamGiac(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void TinhChuVi()
        {
            double chuVi = A + B + C;
            Console.WriteLine($"Chu vi hinh tam giac: {chuVi}");
        }

        public override void TinhDienTich()
        {
            double p = (A + B + C) / 2;
            double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // công thức Heron
            Console.WriteLine($"Dien tich hinh tam giac: {s}");
        }
    }
}
