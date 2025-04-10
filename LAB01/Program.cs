using System;
using System.Text;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1: Nhập tên và tuổi
            Console.WriteLine("Bài 1:");
            Console.Write("Nhập tên: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!\n");

            // Bài 2: Tính diện tích hình chữ nhật
            Console.WriteLine("Bài 2:");
            Console.Write("Nhập chiều dài: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double rong = double.Parse(Console.ReadLine());
            double dienTich = dai * rong;
            Console.WriteLine($"Diện tích hình chữ nhật = {dienTich}\n");

            // Bài 3: Chuyển đổi độ C sang độ F
            Console.WriteLine("Bài 3:");
            Console.Write("Nhập nhiệt độ (°C): ");
            double doC = double.Parse(Console.ReadLine());
            double doF = (doC * 9 / 5) + 32;
            Console.WriteLine($"{doC}°C = {doF}°F\n");

            // Bài 4: Kiểm tra số chẵn
            Console.WriteLine("Bài 4:");
            Console.Write("Nhập một số nguyên: ");
            int soChan = int.Parse(Console.ReadLine());
            Console.WriteLine(soChan % 2 == 0 ? "Số chẵn" : "Số lẻ");
            Console.WriteLine();

            // Bài 5: Tính tổng và tích
            Console.WriteLine("Bài 5:");
            Console.Write("Nhập số thứ nhất: ");
            double so1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double so2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng = {so1 + so2}");
            Console.WriteLine($"Tích = {so1 * so2}\n");

            // Bài 6: Kiểm tra số dương, âm, không
            Console.WriteLine("Bài 6:");
            Console.Write("Nhập một số: ");
            double so = double.Parse(Console.ReadLine());
            if (so > 0) Console.WriteLine("Số dương");
            else if (so < 0) Console.WriteLine("Số âm");
            else Console.WriteLine("Số không");
            Console.WriteLine();

            // Bài 7: Kiểm tra năm nhuận
            Console.WriteLine("Bài 7:");
            Console.Write("Nhập năm: ");
            int nam = int.Parse(Console.ReadLine());
            bool laNamNhuan = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
            Console.WriteLine(laNamNhuan ? "Năm nhuận" : "Không phải năm nhuận");
            Console.WriteLine();

            // Bài 8: Bảng cửu chương
            Console.WriteLine("Bài 8:");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Bài 9: Tính giai thừa
            Console.WriteLine("Bài 9:");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine($"{n}! = {giaiThua}\n");

            // Bài 10: Kiểm tra số nguyên tố
            Console.WriteLine("Bài 10:");
            Console.Write("Nhập số nguyên dương: ");
            int soNguyenTo = int.Parse(Console.ReadLine());
            bool laSoNguyenTo = true;
            if (soNguyenTo < 2) laSoNguyenTo = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(soNguyenTo); i++)
                {
                    if (soNguyenTo % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }
            Console.WriteLine(laSoNguyenTo ? "Số nguyên tố" : "Không phải số nguyên tố");
        }
    }
}