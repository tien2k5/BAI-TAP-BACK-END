using System;
using System.Text;

namespace LAB01
{
    class Program
    {
        // Hàm kiểm tra số nguyên tố
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Bài 1: Tính tổng các số chẵn trong mảng
        static int TongSoChan(int[] arr)
        {
            int tong = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0) tong += num;
            }
            return tong;
        }

        // Bài 5: Hàm hoán vị 2 số
        static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập kích thước mảng
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            double[] arrDouble = new double[n];

            // Nhập mảng số nguyên
            Console.WriteLine("Nhập các phần tử của mảng số nguyên:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Nhập mảng số thực (cho Bài 6)
            Console.WriteLine("Nhập các phần tử của mảng số thực:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử {i}: ");
                arrDouble[i] = double.Parse(Console.ReadLine());
            }

            // Bài 1: Tính tổng số chẵn
            Console.WriteLine("\nBài 1:");
            int tongChan = TongSoChan(arr);
            Console.WriteLine($"Tổng các số chẵn trong mảng: {tongChan}");

            // Bài 2: Tìm số nguyên tố
            Console.WriteLine("\nBài 2:");
            Console.WriteLine("Các số nguyên tố trong mảng:");
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(arr[i]))
                {
                    Console.WriteLine($"Chỉ số {i}: {arr[i]}");
                }
            }

            // Bài 3: Đếm số dương và số âm
            Console.WriteLine("\nBài 3:");
            int soDuong = 0, soAm = 0;
            foreach (int num in arr)
            {
                if (num > 0) soDuong++;
                else if (num < 0) soAm++;
            }
            Console.WriteLine($"Số lượng số dương: {soDuong}");
            Console.WriteLine($"Số lượng số âm: {soAm}");

            // Bài 4: Tìm số lớn thứ hai
            Console.WriteLine("\nBài 4:");
            if (n < 2)
            {
                Console.WriteLine("Mảng cần ít nhất 2 phần tử!");
            }
            else
            {
                int max = arr[0], secondMax = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] > max)
                    {
                        secondMax = max;
                        max = arr[i];
                    }
                    else if (arr[i] > secondMax && arr[i] != max)
                    {
                        secondMax = arr[i];
                    }
                }
                if (secondMax == max)
                    Console.WriteLine("Không tìm thấy số lớn thứ hai!");
                else
                    Console.WriteLine($"Số lớn thứ hai: {secondMax}");
            }

            // Bài 5: Hoán vị 2 số
            Console.WriteLine("\nBài 5:");
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Trước khi hoán vị: a = {a}, b = {b}");
            HoanVi(ref a, ref b);
            Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");

            // Bài 6: Sắp xếp mảng tăng dần
            Console.WriteLine("\nBài 6:");
            Console.WriteLine("Mảng trước khi sắp xếp:");
            Console.WriteLine(string.Join(" ", arrDouble));
            Array.Sort(arrDouble);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(" ", arrDouble));
        }
    }
}