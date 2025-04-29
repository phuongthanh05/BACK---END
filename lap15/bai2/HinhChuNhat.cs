using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
     class HinhChuNhat : Hinh
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public HinhChuNhat(double dai, double rong)
        {
            Dai = dai;
            Rong = rong;
        }

        public override void TinhChuVi()
        {
            double c = 2 * (Dai + Rong);
            Console.WriteLine($"Chu vi hinh chu nhat: {c}");
        }

        public override void TinhDienTich()
        {
            double s = Dai * Rong;
            Console.WriteLine($"Dien tich hinh chu nhat: {s}");
        }
    }
}
