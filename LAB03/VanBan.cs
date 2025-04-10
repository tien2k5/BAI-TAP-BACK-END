using System;
using System.Linq;

namespace BaiTap10
{
    class VanBan
    {
        public string Chuoi { get; set; }
        public void Nhap() { Console.Write("Xâu: "); Chuoi = Console.ReadLine(); }
        public int DemSoTu() => Chuoi.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        public int DemKyTuH() => Chuoi.ToLower().Count(c => c == 'h');
        public string ChuanHoa() => string.Join(" ", Chuoi.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)).Trim();
    }

    class Program
    {
        private static VanBan vb = new VanBan();
        public static void NhapVanBan() => vb.Nhap();

        static void Main(string[] args)
        {
            Console.WriteLine("Xử lý văn bản:");
            Console.WriteLine("\t1. Đếm số từ");
            Console.WriteLine("\t2. Đếm ký tự H");
            Console.WriteLine("\t3. Chuẩn hóa xâu");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            NhapVanBan();
            switch (x)
            {
                case 1:
                    Console.WriteLine($"Số từ: {vb.DemSoTu()}");
                    break;
                case 2:
                    Console.WriteLine($"Số ký tự H: {vb.DemKyTuH()}");
                    break;
                case 3:
                    Console.WriteLine($"Xâu chuẩn hóa: {vb.ChuanHoa()}");
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}