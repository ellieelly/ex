using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ex.session6
{
    internal class ex5
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static long TinhGiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;  
        }
        static string DaoNguocChuoi(string input)
        {
            char[] mangkytu = input.ToCharArray();
            Array.Reverse(mangkytu);
            return new string(mangkytu);
        }
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void InFibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{f0} ");

                // Tính số tiếp theo bằng tổng 2 số trước đó
                int tiepTheo = f0 + f1;
                f0 = f1;
                f1 = tiepTheo;
            }
            Console.WriteLine();
        }
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            string chuThuong = s.ToLower();
            foreach (char c in chuThuong)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    dem++;
                }
            }
            return dem; 
        }
        static double TinhLuyThua(double x, int y)
        {
            double kq = 1;
            for (int i = 1; i <= y; i++)
            {
                kq = kq * x;
            }
            return kq;
        }
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            foreach (int num in arr)
            {
                tong += num;
            }
            return (double)tong / arr.Length;
        }
        static bool KiemTraDoiXung(string s)
        {
            char[] mangKyTu = s.ToCharArray();
            Array.Reverse(mangKyTu);
            string chuoiNguoc = new string(mangKyTu);
            return s.Equals(chuoiNguoc, StringComparison.OrdinalIgnoreCase);
        }
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;    
        }
        static int TimMin(int[] arr)
        {
            int min = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
        static int TongCacChuSo(int n)
        {
            n = Math.Abs(n);
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10; 
                n = n / 10;    
            }
            return tong;
        }
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr); 
            foreach (int item in arr)
            {
                Console.Write($"{item} "); 
            }
            Console.WriteLine();
        }
        static string XoaTrungLap(string s)
        {
            string ketQua = "";
            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }
            return ketQua;
        }
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b; 
                a = b;
                b = r;
            }
            return a;
        }
        static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary; 
                n = n / 2;
            }
            return binary;
        }
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        static int DemSoTu(string sentence)
        {
            string[] tu = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }
        static void bai1()
        {
            //Bài 1: Tính tổng hai số nguyên; Yêu cầu: Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng.
            Console.Write("Nhap a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            int b = int.Parse(Console.ReadLine());
            int tong = TinhTong(a, b);
            Console.WriteLine($"Tong cua {a} va {b} la: {tong}");
        }
        static void bai2()
        {
            //Bài 2: Kiểm tra số chẵn lẻ; Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ.
            Console.Write("Nhap so can kiem tra: ");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraChan(n))
                Console.WriteLine($"{n} la so chan");
            else
                Console.WriteLine($"{n} la so le");
        }
        static void bai3()
        {
            //Bài 3: Tìm số lớn nhất trong ba số; Yêu cầu: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được truyền vào. 
            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            int max = TimMax(a, b, c);
            Console.WriteLine($"So lon nhat trong 3 so la: {max}");
        }
        static void bai4()
        {
            //Bài 4: Tính giai thừa của một số; Yêu cầu: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n(n!).
            Console.Write("Nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine("Vui long nhap so nguyen duong!");
            }
            else
            {
                long kq = TinhGiaiThua(n);
                Console.WriteLine($"{n}! = {kq}");
            }
        }
        static void bai5()
        {
            Console.Write("Nhap chuoi can dao nguoc: ");
            string chuoi = Console.ReadLine();
            string kq = DaoNguocChuoi(chuoi);
            Console.WriteLine($"Chuoi sau khi dao nguoc: {kq}");
        }
        static void bai6()
        {
            //Bài 6: Kiểm tra số nguyên tố; Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên tố hay không.
            Console.Write("Nhap so nguyen n = ");
            int n = int.Parse(Console.ReadLine());
            bool kq = KiemTraNguyenTo(n);
            Console.WriteLine($"output: {kq}");
        }
        static void bai7()
        {
            //Bài 7: In dãy Fibonacci; Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci.
            Console.Write("Nhap n = ");
            
            int n = int.Parse(Console.ReadLine());
            Console.Write("output: ");
            InFibonacci(n);
        }
        static void bai8()
        {
            //Bài 8: Đếm số lượng nguyên âm trong chuỗi; Yêu cầu: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm(a, e, i, o, u) trong chuỗi. 
            Console.Write("Nhap chuoi s = ");
            string s = Console.ReadLine();
            int soNguyenAm = DemNguyenAm(s);
            Console.WriteLine($"output: {soNguyenAm}");
        }
        static void bai9()
        {
            //Bài 9: Tính lũy thừa; Yêu cầu: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y(không dùng Math.Pow).
            Console.Write("Nhap x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y = ");
            int y = int.Parse(Console.ReadLine());
            double ketQua = TinhLuyThua(x, y);
            Console.WriteLine($"output: {ketQua}");
        }
        static void bai10()
        {
            //Bài 10: Tính điểm trung bình của mảng; Yêu cầu: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số nguyên.
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            double tb = TinhTrungBinh(mang);
            Console.WriteLine($"output: {tb}");
        }
        static void bai11()
        {
            //Bài 11: Kiểm tra chuỗi đối xứng (Palindrome); Yêu cầu: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống nhau không.
            Console.Write("Nhap chuoi s = ");
            string s = Console.ReadLine();
            bool ketQua = KiemTraDoiXung(s);
            Console.WriteLine($"Output: {ketQua}");
        }
        static void bai12()
        {
            //Bài 12: Chuyển đổi nhiệt độ; Yêu cầu: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F. 
            Console.Write("Nhap do C = ");
            double c = double.Parse(Console.ReadLine());
            double f = CelsiusToFahrenheit(c);
            Console.WriteLine($"Output: {f}");
        }
        static void bai13()
        {
            //Bài 13: Tìm giá trị nhỏ nhất trong mảng; Yêu cầu: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng. 
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int min = TimMin(mang);
            Console.WriteLine($"Output: {min}");
        }
        static void bai14()
        {
            //Bài 14: Tính tổng các chữ số của một số nguyên; Yêu cầu: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n.
            Console.Write("Nhap so nguyen n = ");
            int n = int.Parse(Console.ReadLine());
            int tong = TongCacChuSo(n);
            Console.WriteLine($"Output: {tong}");
        }
        static void bai15()
        {
            //Bài 15: Sắp xếp mảng tăng dần; Yêu cầu: Viết hàm `void SapXepMang(int[] arr)` sắp xếp và in ra mảng tăng dần. 
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Output: ");
            SapXepMang(mang);
        }
        static void bai16()
        {
            //Bài 16: Xóa ký tự trùng lặp; Yêu cầu: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu tiên được giữ lại.
            Console.Write("Nhap chuoi s = ");
            string s = Console.ReadLine();
            string ketQua = XoaTrungLap(s);
            Console.WriteLine($"Output: {ketQua}");
        }
        static void bai17()
        {
            //Bài 17: Tìm ước chung lớn nhất (UCLN); Yêu cầu: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.
            Console.Write("Nhap a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            int b = int.Parse(Console.ReadLine());
            int ketQua = UCLN(a, b);
            Console.WriteLine($"Output: {ketQua}");
        }
        static void bai18()
        {
            //Bài 18: Chuyển đổi hệ thập phân sang nhị phân; Yêu cầu: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị phân.
            Console.Write("Nhap so thap phan n = ");
            int n = int.Parse(Console.ReadLine());
            string ketQua = DecimalToBinary(n);
            Console.WriteLine($"Output: \"{ketQua}\"");
        }
        static void bai19()
        {
            //Bài 19: Kiểm tra năm nhuận; Yêu cầu: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm nhuận không. 
            Console.Write("Nhap nam = ");
            int year = int.Parse(Console.ReadLine());
            bool ketQua = KiemTraNamNhuan(year);
            Console.WriteLine($"Output: {ketQua}");
        }
        static void bai20()
        {
            //Bài 20: Đếm số từ trong câu; Yêu cầu: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu. 
            Console.Write("Nhap cau: ");
            string sentence = Console.ReadLine();
            int soTu = DemSoTu(sentence);
            Console.WriteLine($"Output: {soTu}");
        }

        static void Main(string[] args)
        {
            bai1();
            bai2();
            bai3();
            bai4();
            bai5();
            bai6();
            bai7();
            bai8();
            bai9();
            bai10();
            bai11();
            bai12();
            bai13();
            bai14();
            bai15();
            bai16();
            bai17();
            bai18();
            bai19();
            bai20();
        }
    }
}
