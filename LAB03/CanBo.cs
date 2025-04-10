using System;
using System.Collections.Generic;

namespace BaiTap1
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Giới tính: "); GioiTinh = Console.ReadLine();
            Console.Write("Địa chỉ: "); DiaChi = Console.ReadLine();
        }
        public virtual void HienThi() => Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
    }

    class CongNhan : CanBo
    {
        public string Bac { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Bậc: "); Bac = Console.ReadLine(); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Bậc: {Bac}");
    }

    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Ngành đào tạo: "); NganhDaoTao = Console.ReadLine(); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Ngành: {NganhDaoTao}");
    }

    class NhanVien : CanBo
    {
        public string CongViec { get; set; }
        public override void Nhap() { base.Nhap(); Console.Write("Công việc: "); CongViec = Console.ReadLine(); }
        public override void HienThi() => Console.WriteLine($"{base.HienThi()}, Công việc: {CongViec}");
    }

    class Program
    {
        private static List<CanBo> danhSach = new List<CanBo>();
        public static void NhapCanBo()
        {
            Console.Write("Loại (1-Công nhân, 2-Kỹ sư, 3-Nhân viên): ");
            int type = int.Parse(Console.ReadLine());
            CanBo cb = type == 1 ? new CongNhan() : type == 2 ? new KySu() : new NhanVien();
            cb.Nhap(); danhSach.Add(cb);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quản lý cán bộ:");
            Console.WriteLine("\t1. Nhập cán bộ");
            Console.WriteLine("\t2. Tìm theo họ tên");
            Console.WriteLine("\t3. Hiển thị danh sách");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapCanBo();
                    Console.WriteLine("Đã thêm cán bộ!");
                    break;
                case 2:
                    Console.Write("Họ tên cần tìm: ");
                    string ten = Console.ReadLine();
                    foreach (var cb in danhSach) if (cb.HoTen.Contains(ten)) cb.HienThi();
                    break;
                case 3:
                    foreach (var cb in danhSach) cb.HienThi();
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}