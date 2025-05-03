﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;


namespace Bai1Lab1._3
{
    internal class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Năm sinh: {NamSinh}");
            Console.WriteLine($"Giới tính: {GioiTinh}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
        }
    }
}
