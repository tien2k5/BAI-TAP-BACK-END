using System;

namespace BaiTap11
{
    class SoPhuc
    {
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }
        public void Nhap() { Console.Write("Phần thực: "); PhanThuc = double.Parse(Console.ReadLine()); Console.Write("Phần ảo: "); PhanAo = double.Parse(Console.ReadLine()); }
        public void HienThi() => Console.WriteLine($"{PhanThuc} + {PhanAo}i");
        public static SoPhuc operator +(SoPhuc a, SoPhuc b) => new SoPhuc { PhanThuc = a.PhanThuc + b.PhanThuc, PhanAo = a.PhanAo + b.PhanAo };
        public static SoPhuc operator -(SoPhuc a, SoPhuc b) => new SoPhuc { PhanThuc = a.PhanThuc - b.PhanThuc, PhanAo = a.PhanAo - b.PhanAo };
        public static SoPhuc operator *(SoPhuc a, SoPhuc b) => new SoPhuc { PhanThuc = a.PhanThuc * b.PhanThuc - a.PhanAo * b.PhanAo, PhanAo = a.PhanThuc * b.PhanAo + a.PhanAo * b.PhanThuc };
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            double mau = b.PhanThuc * b.PhanThuc + b.PhanAo * b.PhanAo;
            return new SoPhuc { PhanThuc = (a.PhanThuc * b.PhanThuc + a.PhanAo * b.PhanAo) / mau, PhanAo = (a.PhanAo * b.PhanThuc - a.PhanThuc * b.PhanAo) / mau };
        }
    }

    class Program
    {
        public static void NhapSoPhuc(SoPhuc a, SoPhuc b) { Console.WriteLine("Số phức 1:"); a.Nhap(); Console.WriteLine("Số phức 2:"); b.Nhap(); }

        static void Main(string[] args)
        {
            SoPhuc sp1 = new SoPhuc(), sp2 = new SoPhuc(), sp3 = new SoPhuc();
            Console.WriteLine("Các phép toán của số phức:");
            Console.WriteLine("\t1. Nhập 1 nếu muốn cộng");
            Console.WriteLine("\t2. Nhập 2 nếu muốn trừ");
            Console.WriteLine("\t3. Nhập 3 nếu muốn nhân");
            Console.WriteLine("\t4. Nhập 4 nếu muốn chia");
            Console.Write("- Mời bạn nhập lựa chọn: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    NhapSoPhuc(sp1, sp2);
                    sp3 = sp1 + sp2;
                    Console.WriteLine($"Kết quả: {sp1.PhanThuc}+{sp1.PhanAo}i + {sp2.PhanThuc}+{sp2.PhanAo}i = {sp3.PhanThuc}+{sp3.PhanAo}i");
                    break;
                case 2:
                    NhapSoPhuc(sp1, sp2);
                    sp3 = sp1 - sp2;
                    Console.WriteLine($"Kết quả: {sp1.PhanThuc}+{sp1.PhanAo}i - {sp2.PhanThuc}+{sp2.PhanAo}i = {sp3.PhanThuc}+{sp3.PhanAo}i");
                    break;
                case 3:
                    NhapSoPhuc(sp1, sp2);
                    sp3 = sp1 * sp2;
                    Console.WriteLine($"Kết quả: {sp1.PhanThuc}+{sp1.PhanAo}i * {sp2.PhanThuc}+{sp2.PhanAo}i = {sp3.PhanThuc}+{sp3.PhanAo}i");
                    break;
                case 4:
                    NhapSoPhuc(sp1, sp2);
                    sp3 = sp1 / sp2;
                    Console.WriteLine($"Kết quả: {sp1.PhanThuc}+{sp1.PhanAo}i / {sp2.PhanThuc}+{sp2.PhanAo}i = {sp3.PhanThuc}+{sp3.PhanAo}i");
                    break;
                default:
                    Console.WriteLine("Nhập sai!!!");
                    break;
            }
        }
    }
}