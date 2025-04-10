using System;
using System.Collections.Generic;

namespace BaiTap5
{
    class QLKhachSan
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

    class KhachTro : Nguoi
    {
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; }
        public double GiaPhong { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Số ngày: "); SoNgayTro = int.Parse(Console.ReadLine()); Console.Write("Loại phòng: "); LoaiPhong = Console.ReadLine(); Console.Write("Giá: "); GiaPhong = double.Parse(Console.ReadLine()); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Số ngày: {SoNgayTro}, Loại phòng: {LoaiPhong}, Giá: {GiaPhong}");
        public double TinhTien() => SoNgayTro * GiaPhong;
    }

    class Program
    {
        private static List<KhachTro> danhSach = new List<KhachTro>();
        public static void NhapKhachTro()
        {
            Console.Write("Số khách: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { KhachTro kt = new KhachTro(); kt.Nhap(); danhSach.Add(kt); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý khách sạn:");
            Console.WriteLine("\t1. Nhập khách trọ");
            Console.WriteLine("\t2. Hiển thị danh sách");
            Console.WriteLine("\t3. Tìm theo họ tên");
            Console.WriteLine("\t4. Tính tiền");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapKhachTro();
                    Console.WriteLine("Đã thêm khách!");
                    break;
                case 2:
                    foreach (var kt in danhSach) kt.HienThi();
                    break;
                case 3:
                    Console.Write("Họ tên: ");
                    string ten = Console.ReadLine();
                    foreach (var kt in danhSach) if (kt.HoTen.Contains(ten)) kt.HienThi();
                    break;
                case 4:
                    Console.Write("Họ tên: ");
                    string tenTinh = Console.ReadLine();
                    foreach (var kt in danhSach) if (kt.HoTen == tenTinh) Console.WriteLine($"Tiền phải trả: {kt.TinhTien()}");
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}