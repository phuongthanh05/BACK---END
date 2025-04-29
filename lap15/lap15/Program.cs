using lap15;

class Program
{
    static void Main(string[] args)
    {
        List<PhanSo> danhSachPhanSo = new List<PhanSo>();

        Console.Write("Nhap so luong phan so: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"> Phan so thu {i + 1}:");
            Console.Write("  Nhap tu so: ");
            int tu = int.Parse(Console.ReadLine());
            Console.Write("  Nhap mau so: ");
            int mau = int.Parse(Console.ReadLine());

            danhSachPhanSo.Add(new PhanSo(tu, mau));
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSachPhanSo)
        {
            tong = PhanSo.Cong(tong, ps);
        }

        Console.WriteLine($"=> Tong cac phan so la: {tong}");
    }
}