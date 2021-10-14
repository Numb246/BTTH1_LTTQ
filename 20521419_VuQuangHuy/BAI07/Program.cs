using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI07
{
    class Program
    {
        int n, m;
        public void nhapMang(ref int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void xuatMang(int[,] a)
        {
            Console.WriteLine("Mang khoi tao: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void timLN(int[,] a)
        {
            int max = a.Cast<int>().Max(); // Cast<int> method dung de chuyen doi mang 2 chieu thanh 1 chuoi cac so kieu int
            Console.WriteLine("Gia tri lon nhat cua mang: " + max);// de xay ra overflow neu co qua nhieu phan tu, gia tri lon
        }
        public void timNN(int[,] a)
        {
            int min = a.Cast<int>().Min();
            Console.WriteLine("Gia tri nho nhat cua mang: " + min);
        }
        public void timDLN(int[,] a)
        {
            int max = 0;
            int max_v = 0;
            for (int i = 0; i < n; i++)
            {
                int tmp = max_v;
                max_v = 0;
                for (int j = 0; j < m; j++)
                {
                    max_v += a[i, j];
                    if (tmp > max_v)
                    {
                        max_v = tmp;
                        max = i;
                    }
                }
            }
            Console.WriteLine("Dong co tong so lon nhat: " + max + 1);
        }
        public bool kt_SNT(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void tongKSNT(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (kt_SNT(a[i, j]) == false)
                    {
                        sum += a[i, j];
                    }
                    else continue;
                }
            }
            Console.WriteLine("Tong cac so khong phai la so nguyen to la: " + sum);
        }
        public void xoa1dong(int[,] a)
        {
            Console.WriteLine("Dong muon xoa: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (n < k || k == 0)
            {
                Console.WriteLine("Dong " + k + " nam ngoai mang. Khong the xoa!");
            }
            else
            {
                int tmp_i = 0;
                int[,] b = new int[n - 1, m];
                for (int i = 0; i < n; i++)
                {
                    if (i == k - 1)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = 0; j < m; j++)
                        {
                            b[tmp_i, j] = a[i, j];
                        }
                        tmp_i++;
                    }
                }
                Console.WriteLine("Mang moi sau khi xoa dong: ");
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(b[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void xoaCot(int[,] a)
        {
            int max = a[0, 0];
            int max_col = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        max_col = j;
                    }
                }
            }
            int[,] b = new int[n, m - 1];
            int tmp_j = 0;
            for (int j = 0; j < m; j++)
            {
                if (j == max_col)
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        b[i, tmp_j] = a[i, j];
                    }
                    tmp_j++;
                }
            }
            Console.WriteLine("Mang moi sau khi xoa cot: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Nhap so dong, cot: ");
            p.n = Convert.ToInt32((Console.ReadLine()));
            p.m = Convert.ToInt32((Console.ReadLine()));
            int[,] a = new int[p.n, p.m];
            p.nhapMang(ref a); // do truy cap vao ham cua class nen can tao doi tuong class do trc
            p.xuatMang(a);
            p.timLN(a);
            p.timNN(a);
            p.timDLN(a);
            p.tongKSNT(a);
            p.xoa1dong(a);
            p.xoaCot(a);
        }
    }
}

