using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTap3
{
    class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int UuTien { get; set; }
        public double[] Diem { get; set; }
        public virtual void Nhap()
        {
            Console.Write("SBD: "); SoBaoDanh = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Địa chỉ: "); DiaChi = Console.ReadLine();
            Console.Write("Ưu tiên: "); UuTien = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi() => Console.WriteLine($"SBD: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ưu tiên: {UuTien}");
        public virtual double TongDiem() => Diem.Sum() + UuTien;
    }

    class KhoiA : ThiSinh
    {
        public override void Nhap() { base.Nhap(); Diem = new double[3]; Console.Write("Toán: "); Diem[0] = double.Parse(Console.ReadLine()); Console.Write("Lý: "); Diem[1] = double.Parse(Console.ReadLine()); Console.Write("Hóa: "); Diem[2] = double.Parse(Console.ReadLine()); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Toán: {Diem[0]}, Lý: {Diem[1]}, Hóa: {Diem[2]}, Tổng: {TongDiem()}");
    }

    class KhoiB : ThiSinh
    {
        public override void Nhap() { base.Nhap(); Diem = new double[3]; Console.Write("Toán: "); Diem[0] = double.Parse(Console.ReadLine()); Console.Write("Hóa: "); Diem[1] = double.Parse(Console.ReadLine()); Console.Write("Sinh: "); Diem[2] = double.Parse(Console.ReadLine()); }
        public override void HienThi()
        {
            Console.WriteLine($"{base.HienThi()}, Toán: {Diem[0]}, Hóa: {Diem[1]}, Sinh: {Diem[2]}, Tổng: {TongDiem()}");
        }
    }

    class KhoiC : ThiSinh
    {
        public override void Nhap() { base.Nhap(); Diem = new double[3]; Console.Write("Văn: "); Diem[0] = double.Parse(Console.ReadLine()); Console.Write("Sử: "); Diem[1] = double.Parse(Console.ReadLine()); Console.Write("Địa: "); Diem[2] = double.Parse(Console.ReadLine()); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Văn: {Diem[0]}, Sử: {Diem[1]}, Địa: {Diem[2]}, Tổng: {TongDiem()}");
    }

    class Program
    {
        private static List<ThiSinh> danhSach = new List<ThiSinh>();
        public static void NhapThiSinh()
        {
            Console.Write("Khối (1-A, 2-B, 3-C): ");
            int type = int.Parse(Console.ReadLine());
            ThiSinh ts = type == 1 ? new KhoiA() : type == 2 ? new KhoiB() : new KhoiC();
            ts.Nhap(); danhSach.Add(ts);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý thí sinh:");
            Console.WriteLine("\t1. Nhập thí sinh");
            Console.WriteLine("\t2. Hiển thị trúng tuyển");
            Console.WriteLine("\t3. Tìm theo SBD");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapThiSinh();
                    Console.WriteLine("Đã thêm thí sinh!");
                    break;
                case 2:
                    foreach (var ts in danhSach)
                        if ((ts is KhoiA && ts.TongDiem() >= 15) || (ts is KhoiB && ts.TongDiem() >= 16) || (ts is KhoiC && ts.TongDiem() >= 13.5))
                            ts.HienThi();
                    break;
                case 3:
                    Console.Write("SBD cần tìm: ");
                    string sbd = Console.ReadLine();
                    foreach (var ts in danhSach) if (ts.SoBaoDanh == sbd) ts.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}