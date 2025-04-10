using System;
using System.Collections.Generic;

namespace BaiTap6
{
    class QLHS
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public void Nhap()
        {
            Console.Write("CMND: "); CMND = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Tuổi: "); Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghề: "); NgheNghiep = Console.ReadLine();
            Console.Write("Giới tính: "); GioiTinh = Console.ReadLine();
            Console.Write("Quê quán: "); QueQuan = Console.ReadLine();
        }
        public void HienThi() => Console.WriteLine($"CMND: {CMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề: {NgheNghiep}, Giới tính: {GioiTinh}, Quê: {QueQuan}");
    }

    class HSHocSinh : Nguoi
    {
        public string Lop { get; set; }
        public string KhoaHoc { get; set; }
        public string KyHoc { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Lớp: "); Lop = Console.ReadLine(); Console.Write("Khóa: "); KhoaHoc = Console.ReadLine(); Console.Write("Kỳ: "); KyHoc = Console.ReadLine(); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Lớp: {Lop}, Khóa: {KhoaHoc}, Kỳ: {KyHoc}");
    }

    class Program
    {
        private static List<HSHocSinh> danhSach = new List<HSHocSinh>();
        public static void NhapHS()
        {
            Console.Write("Số HS: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { HSHocSinh hs = new HSHocSinh(); hs.Nhap(); danhSach.Add(hs); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý học sinh:");
            Console.WriteLine("\t1. Nhập học sinh");
            Console.WriteLine("\t2. Hiển thị nữ sinh 1985");
            Console.WriteLine("\t3. Tìm theo quê quán");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapHS();
                    Console.WriteLine("Đã thêm học sinh!");
                    break;
                case 2:
                    foreach (var hs in danhSach) if (hs.GioiTinh.ToLower() == "nữ" && hs.NamSinh == 1985) hs.HienThi();
                    break;
                case 3:
                    Console.Write("Quê quán: ");
                    string que = Console.ReadLine();
                    foreach (var hs in danhSach) if (hs.QueQuan.Contains(que)) hs.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}