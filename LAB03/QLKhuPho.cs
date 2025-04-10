using System;
using System.Collections.Generic;

namespace BaiTap4
{
    class QLKhuPho

    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }
        public void Nhap()
        {
            Console.Write("CMND: "); CMND = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Tuổi: "); Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghề: "); NgheNghiep = Console.ReadLine();
        }
        public void HienThi() => Console.WriteLine($"CMND: {CMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề: {NgheNghiep}");
    }

    class HoDan
    {
        public int SoThanhVien { get; set; }
        public string SoNha { get; set; }
        public List<QLKhuPho> ThanhVien { get; set; }
        public void Nhap()
        {
            Console.Write("Số thành viên: "); SoThanhVien = int.Parse(Console.ReadLine());
            Console.Write("Số nhà: "); SoNha = Console.ReadLine();
            ThanhVien = new List<QLKhuPho>();
            for (int i = 0; i < SoThanhVien; i++) { Console.WriteLine($"Thành viên {i + 1}:"); QLKhuPho n = new QLKhuPho(); n.Nhap(); ThanhVien.Add(n); }
        }
        public void HienThi() { Console.WriteLine($"Số nhà: {SoNha}, Số thành viên: {SoThanhVien}"); ThanhVien.ForEach(tv => tv.HienThi()); }
    }

    class Program
    {
        private static List<HoDan> danhSach = new List<HoDan>();
        public static void NhapHoDan()
        {
            Console.Write("Số hộ: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { HoDan hd = new HoDan(); hd.Nhap(); danhSach.Add(hd); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý khu phố:");
            Console.WriteLine("\t1. Nhập hộ dân");
            Console.WriteLine("\t2. Tìm theo họ tên");
            Console.WriteLine("\t3. Tìm theo số nhà");
            Console.WriteLine("\t4. Hiển thị danh sách");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapHoDan();
                    Console.WriteLine("Đã thêm hộ dân!");
                    break;
                case 2:
                    Console.Write("Họ tên: ");
                    string ten = Console.ReadLine();
                    foreach (var hd in danhSach) foreach (var tv in hd.ThanhVien) if (tv.HoTen.Contains(ten)) hd.HienThi();
                    break;
                case 3:
                    Console.Write("Số nhà: ");
                    string soNha = Console.ReadLine();
                    foreach (var hd in danhSach) if (hd.SoNha == soNha) hd.HienThi();
                    break;
                case 4:
                    foreach (var hd in danhSach) hd.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}