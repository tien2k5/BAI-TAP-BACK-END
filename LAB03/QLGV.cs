using System;
using System.Collections.Generic;

namespace BaiTap7
{
    class QLGV
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }
        public string QueQuan { get; set; }
        public void Nhap()
        {
            Console.Write("CMND: "); CMND = Console.ReadLine();
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Tuổi: "); Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghề: "); NgheNghiep = Console.ReadLine();
            Console.Write("Quê quán: "); QueQuan = Console.ReadLine();
        }
        public void HienThi() => Console.WriteLine($"CMND: {CMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề: {NgheNghiep}, Quê: {QueQuan}");
    }

    class CBGV : Nguoi
    {
        public double LuongCung { get; set; }
        public double Thuong { get; set; }
        public double Phat { get; set; }
        public double LuongThucLinh => LuongCung + Thuong - Phat;
        public override void Nhap() { base.Nhap(); Console.Write("Lương cứng: "); LuongCung = double.Parse(Console.ReadLine()); Console.Write("Thưởng: "); Thuong = double.Parse(Console.ReadLine()); Console.Write("Phạt: "); Phat = double.Parse(Console.ReadLine()); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Lương thực lĩnh: {LuongThucLinh}");
    }

    class Program
    {
        private static List<CBGV> danhSach = new List<CBGV>();
        public static void NhapCBGV()
        {
            Console.Write("Số CBGV: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { CBGV gv = new CBGV(); gv.Nhap(); danhSach.Add(gv); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý giáo viên:");
            Console.WriteLine("\t1. Nhập CBGV");
            Console.WriteLine("\t2. Tìm theo quê quán");
            Console.WriteLine("\t3. Hiển thị lương > 5tr");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapCBGV();
                    Console.WriteLine("Đã thêm CBGV!");
                    break;
                case 2:
                    Console.Write("Quê quán: ");
                    string que = Console.ReadLine();
                    foreach (var gv in danhSach) if (gv.QueQuan.Contains(que)) gv.HienThi();
                    break;
                case 3:
                    foreach (var gv in danhSach) if (gv.LuongThucLinh > 5000000) gv.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}