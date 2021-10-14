using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI01
{
    class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            int flag = 0;
            if (nam % 4 == 0 || nam % 400 == 0)
            {
                flag = 1;
            }
            Console.Write("So ngay co trong thang " + thang + ": ");
            switch(thang)
            {
                case 1: Console.WriteLine("31 ngay");
                    break;
                case 3: Console.WriteLine("31 ngay");
                    break;
                case 4: Console.WriteLine("30 ngay");
                    break;
                case 5: Console.WriteLine("31 ngay");
                    break;
                case 6: Console.WriteLine("30 ngay");
                    break;
                case 7: Console.WriteLine("31 ngay");
                    break;
                case 8: Console.WriteLine("31 ngay");
                    break;
                case 9: Console.WriteLine("30 ngay");
                    break;
                case 10: Console.WriteLine("31 ngay");
                    break;
                case 11: Console.WriteLine("30 ngay");
                    break;
                case 12: Console.WriteLine("31 ngay");
                    break;
                default: break;
            }
            if (thang == 2 && flag == 1)
            {
                Console.WriteLine("29 ngay");
            }
            else if (thang == 2 && flag == 0) 
            {
                Console.WriteLine("28 ngay");
            }
        }
    }
}
