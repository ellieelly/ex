using System;
using System.Collections.Generic;
using System.Text;

namespace ex.session7
{
    internal class ex6
    {
        static int[] TaoMang(int n)
        {
            Random rd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(1, 20);
            }
            return a;
        }
        static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        //bai1
        static float calcAvg(int[] a)
        {
            int sum = 0;
            foreach (int v in a)
            {
                sum += v;
            }
            return (float)sum / a.Length;
        }
        //bai2
        static bool CoChua(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return true;
            }
            return false;
        }
        //bai3
        static int findIndex(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }
        //bai4
        static int[] removeElement(int[] a, int x)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != x) count++;
            }

            int[] result = new int[count];
            int idx = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != x)
                {
                    result[idx] = a[i];
                    idx++;
                }
            }
            return result;
        }
        //bai5
        static void findMaxMin(int[] a, out int max, out int min)
        {
            max = a[0];
            min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
        }
        //bai6
        static void reverseArray(int[] a)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
        }
        //bai7
        static void findDuplicates(int[] a)
        {
            Console.Write("Cac phan tu trung lap: ");
            bool found = false;
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool alreadyPrinted = false;
                for (int k = 0; k < i; k++)
                {
                    if (a[k] == a[i])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }
                if (alreadyPrinted) continue;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.Write($"{a[i]} ");
                        found = true;
                        break;
                    }
                }
            }
            if (!found) Console.Write("Khong co");
            Console.WriteLine();
        }
        //bai8
        static int[] removeDuplicates(int[] a)
        {
            int uniqueCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        duplicate = true;
                        break
                    }
                }
                if (!duplicate) uniqueCount++;
            }
            int[] uniqueArray = new int[uniqueCount];
            int idx = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    uniqueArray[idx] = a[i];
                    idx++;
                }
            }
            return uniqueArray;
        }

        static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static bool LinearSearchWord(string sentence, string word)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Nhap 10 so nguyen:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Phan tu [{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(numbers);
            Console.Write("Mang sau khi sap xep Bubble Sort: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\n-------------------------------------------");
            Console.Write("Nhap mot cau: ");
            string sentence = Console.ReadLine();
            Console.Write("Nhap tu can tim: ");
            string word = Console.ReadLine();
            bool found = LinearSearchWord(sentence, word);
            if (found)
                Console.WriteLine($"Tu '{word}' CO xuat hien trong cau.");
            else
                Console.WriteLine($"Tu '{word}' KHONG xuat hien trong cau.");
        }

        static int[,] TaoMaTran(int rows, int cols)
        {
            Random rd = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rd.Next(1, 30);
                }
            }
            return matrix;
        }
        static void InMaTran(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        static void InDong(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            Console.Write($"Dong {rowIndex}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[rowIndex, j]} ");
            }
            Console.WriteLine();
        }
        static void InCot(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            Console.Write($"Cot {colIndex}: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, colIndex]} ");
            }
            Console.WriteLine();
        }
        static int TimMaxMaTran(int[,] matrix)
        {
            int max = matrix[0, 0];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
            }
            return max;
        }
        static int TimMinDong(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            int min = matrix[rowIndex, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[rowIndex, j] < min) min = matrix[rowIndex, j];
            }
            return min;
        }
        static int TimMinCot(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int min = matrix[0, colIndex];
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, colIndex] < min) min = matrix[i, colIndex];
            }
            return min;
        }
        static int[,] ChuyenViMaTran(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }
            return transposed;
        }
        static void InDuongCheo(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("Day khong phai ma tran vuong, khong co duong cheo!");
                return;
            }
            Console.Write("Duong cheo chinh (Main diagonal): ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }
            Console.WriteLine();

            Console.Write("Duong cheo phu (Secondary diagonal): ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, rows - 1 - i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = TaoMaTran(n, m);
            Console.WriteLine("\n--- MA TRAN BAN DAU ---");
            InMaTran(matrix);
            Console.Write($"\nNhap chi so dong can in (0 den {n - 1}): ");
            int r = int.Parse(Console.ReadLine());
            if (r >= 0 && r < n)
            {
                InDong(matrix, r);
                Console.WriteLine($"Min cua dong {r} la: {TimMinDong(matrix, r)}");
            }
            Console.Write($"\nNhap chi so cot can in (0 den {m - 1}): ");
            int c = int.Parse(Console.ReadLine());
            if (c >= 0 && c < m)
            {
                InCot(matrix, c);
                Console.WriteLine($"Min cua cot {c} la: {TimMinCot(matrix, c)}");
            }
            Console.WriteLine($"\nGia tri lon nhat (Max) cua ma tran: {TimMaxMaTran(matrix)}");
            Console.WriteLine("\n--- MA TRAN CHUYEN VI ---");
            int[,] trans = ChuyenViMaTran(matrix);
            InMaTran(trans);
            Console.WriteLine("\n--- DUONG CHEO ---");
            InDuongCheo(matrix);
        }
    }
}



