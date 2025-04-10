using System;
using System.Collections.Generic;

namespace BaiTap2
{
    class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenNXB { get; set; }
        public int SoBanPhatHanh { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Mã: "); MaTaiLieu = Console.ReadLine();
            Console.Write("NXB: "); TenNXB = Console.ReadLine();
            Console.Write("Số bản: "); SoBanPhatHanh = int.Parse(Console.ReadLine());
        }
        public virtual void HienThi() => Console.WriteLine($"Mã: {MaTaiLieu}, NXB: {TenNXB}, Số bản: {SoBanPhatHanh}");
    }

    class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Tác giả: "); TenTacGia = Console.ReadLine(); Console.Write("Số trang: "); SoTrang = int.Parse(Console.ReadLine()); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Tác giả: {TenTacGia}, Số trang: {SoTrang}");
    }

    class TapChi : TaiLieu
    {
        public string SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Số PH: "); SoPhatHanh = Console.ReadLine(); Console.Write("Tháng PH: "); ThangPhatHanh = int.Parse(Console.ReadLine()); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Số PH: {SoPhatHanh}, Tháng PH: {ThangPhatHanh}");
    }

    class Bao : TaiLieu
    {
        public string NgayPhatHanh { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Ngày PH: "); NgayPhatHanh = Console.ReadLine(); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Ngày PH: {NgayPhatHanh}");
    }

    class Program
    {
        private static List<TaiLieu> danhSach = new List<TaiLieu>();
        public static void NhapTaiLieu()
        {
            Console.Write("Loại (1-Sách, 2-Tạp chí, 3-Báo): ");
            int type = int.Parse(Console.ReadLine());
            TaiLieu tl = type == 1 ? new Sach() : type == 2 ? new TapChi() : new Bao();
            tl.Nhap(); danhSach.Add(tl);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý tài liệu:");
            Console.WriteLine("\t1. Nhập tài liệu");
            Console.WriteLine("\t2. Hiển thị danh sách");
            Console.WriteLine("\t3. Tìm theo loại");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapTaiLieu();
                    Console.WriteLine("Đã thêm tài liệu!");
                    break;
                case 2:
                    foreach (var tl in danhSach) tl.HienThi();
                    break;
                case 3:
                    Console.Write("Loại (Sach/TapChi/Bao): ");
                    string loai = Console.ReadLine();
                    foreach (var tl in danhSach) if (tl.GetType().Name == loai) tl.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}