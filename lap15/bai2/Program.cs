
using bai2;


    class Program
{
    static void Main()
    {
        List<Hinh> danhSachHinh = new List<Hinh>();

        danhSachHinh.Add(new HinhTron(5));
        danhSachHinh.Add(new HinhVuong(4));
        danhSachHinh.Add(new HinhChuNhat(3, 6));
        danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

        Console.WriteLine("======== Ket qua tinh chu vi va dien tich==========");

        foreach (Hinh hinh in danhSachHinh)
        {
            hinh.TinhChuVi();
            hinh.TinhDienTich();
          
        }

    }
}

