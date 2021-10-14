using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            List<int> a = new List<int>(n);
            for (int i = 0;i<n;i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }
            int sum = Sum(a);
            int soNT = Count(a);
            int soCPNN = Find(a);
            Console.WriteLine("Tong phan tu le trong mang: " + sum);
            Console.WriteLine("So phan tu la so nguyen to trong mang: " + soNT);
            Console.WriteLine("So chinh phuong nho nhat trong mang: " + soCPNN);
        }

        private static int Find(List<int> a)
        {
            int min = 0;
            int flag = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if(KTSCP(a[i]))
                {
                    if (flag ==0)
                    {
                        min = a[i];
                        flag = 1;
                    }
                    if (min > a[i] && flag == 1) 
                    {
                        min = a[i];
                    }
                }
            }
            return min;
        }

        private static bool KTSCP(int v)
        {
            if (v % Math.Sqrt(v) == 0)
            {
                return true;
            }
            return false;
        }

        private static int Count(List<int> a)
        {
            int count = 0;
            for (int i = 0;i<a.Count;i++)
            {
                if (ktSNT(a[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        private static bool ktSNT(int v)
        {
            for (int i = 2; i <= Math.Sqrt(v); i++) 
            {
                if (v % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        private static int Sum(List<int> a)
        {
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] % 2 != 0) 
                {
                    sum += a[i];
                }
            }
            return sum;
        }
    }
}
