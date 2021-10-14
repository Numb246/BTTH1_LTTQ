using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac 2: ax2 + bx + c");
            Console.WriteLine("Nhap cac gia tri a, b, c lan luot: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            GiaiPhuongTrinh(a, b, c);
        }

        private static void GiaiPhuongTrinh(double a, double b, double c)
        {
            double x1, x2;
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                x1 = x2 = -b/(2*a);
                Console.WriteLine("Phuong trinh co nghiem kep: " + -b / (2*a));
            }
            else
            {   
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                x1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                x2 = ((-b - Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
