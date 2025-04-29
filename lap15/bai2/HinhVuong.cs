using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HinhVuong : Hinh
    {
        public double Canh { get; set; }

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public override void TinhChuVi()
        {
            double c = 4 * Canh;
            Console.WriteLine($"Chu vi hinh vuong: {c}");
        }

        public override void TinhDienTich()
        {
            double s = Canh * Canh;
            Console.WriteLine($"Dien tich hinh vuong: {s}");
        }

    }
}
