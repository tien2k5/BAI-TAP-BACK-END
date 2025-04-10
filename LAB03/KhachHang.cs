using System;
using System.Collections.Generic;

namespace BaiTap9
{
    class KhachHang
    {
        public string HoTenChuHo { get; set; }
        public string SoNha { get; set; }
        public string MaSoCongTo { get; set; }
        public void Nhap()
        {
            Console.Write("Chủ hộ: "); HoTenChuHo = Console.ReadLine();
            Console.Write("Số nhà: "); SoNha = Console.ReadLine();
            Console.Write("Mã công tơ: "); MaSoCongTo = Console.ReadLine();
        }
        public void HienThi() => Console.WriteLine($"Chủ hộ: {HoTenChuHo}, Số nhà: {SoNha}, Mã công tơ: {MaSoCongTo}");
    }

    class BienLai
    {
        public KhachHang KH { get; set; }
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public double TinhTien()
        {
            int soDien = ChiSoMoi - ChiSoCu;
            if (soDien < 50) return soDien * 1250;
            if (soDien < 100) return soDien * 1500;
            return soDien * 2000;
        }
        public void Nhap()
        {
            KH = new KhachHang(); KH.Nhap();
            Console.Write("Chỉ số cũ: "); ChiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Chỉ số mới: "); ChiSoMoi = int.Parse(Console.ReadLine());
        }
        public void HienThi() { KH.HienThi(); Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, Chỉ số mới: {ChiSoMoi}, Tiền: {TinhTien()}"); }
    }

    class Program
    {
        private static List<BienLai> danhSach = new List<BienLai>();
        public static void NhapBienLai()
        {
            Console.Write("Số hộ: "); int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { BienLai bl = new BienLai(); bl.Nhap(); danhSach.Add(bl); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý biên lai điện:");
            Console.WriteLine("\t1. Nhập biên lai");
            Console.WriteLine("\t2. Hiển thị danh sách");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapBienLai();
                    Console.WriteLine("Đã thêm biên lai!");
                    break;
                case 2:
                    foreach (var bl in danhSach) bl.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}