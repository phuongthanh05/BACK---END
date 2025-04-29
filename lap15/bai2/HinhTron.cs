using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        //  khởi tạo 
        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }
        public override void TinhChuVi()
        {
            double chuVi = 2 * Math.PI * BanKinh; // C = 2 * π * r
            Console.WriteLine($"Chu vi hinh tron: {chuVi}");
        }

        // phương thức tính diện tích hình tròn và in kết quả trực tiếp
        public override void TinhDienTich()
        {
            double dienTich = Math.PI * BanKinh * BanKinh; // A = π * r^2
            Console.WriteLine($"Dien tich hinh tron: {dienTich}");
        }
    
}
}
