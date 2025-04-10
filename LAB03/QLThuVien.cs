using System;
using System.Collections.Generic;

namespace BaiTap8
{
    class QLThuVien

    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string Lop { get; set; }
        public string MaSV { get; set; }
        public void Nhap()
        {
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Lớp: "); Lop = Console.ReadLine();
            Console.Write("Mã SV: "); MaSV = Console.ReadLine();
        }
        public void HienThi() => Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, Mã SV: {MaSV}");
    }

    class TheMuon
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }
        public SinhVien SV { get; set; }
        public void Nhap()
        {
            Console.Write("Số phiếu: "); SoPhieuMuon = Console.ReadLine();
            Console.Write("Ngày mượn (dd/MM/yyyy): "); NgayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Hạn trả (dd/MM/yyyy): "); HanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Số hiệu sách: "); SoHieuSach = Console.ReadLine();
            SV = new SinhVien(); SV.Nhap();
        }
        public void HienThi() { Console.WriteLine($"Phiếu: {SoPhieuMuon}, Ngày mượn: {NgayMuon:dd/MM/yyyy}, Hạn trả: {HanTra:dd/MM/yyyy}, Sách: {SoHieuSach}"); SV.HienThi(); }
    }

    class Program
    {
        private static List<TheMuon> danhSach = new List<TheMuon>();
        public static void NhapTheMuon()
        {
            Console.Write("Số thẻ: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { TheMuon tm = new TheMuon(); tm.Nhap(); danhSach.Add(tm); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý mượn sách:");
            Console.WriteLine("\t1. Nhập thẻ mượn");
            Console.WriteLine("\t2. Tìm theo mã SV");
            Console.WriteLine("\t3. Hiển thị thẻ đến hạn");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapTheMuon();
                    Console.WriteLine("Đã thêm thẻ mượn!");
                    break;
                case 2:
                    Console.Write("Mã SV: ");
                    string ma = Console.ReadLine();
                    foreach (var tm in danhSach) if (tm.SV.MaSV == ma) tm.HienThi();
                    break;
                case 3:
                    DateTime now = DateTime.Now;
                    foreach (var tm in danhSach) if (tm.HanTra <= now) tm.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}