using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so tien: ");
            int tien = int.Parse(Console.ReadLine());
            List<int> t = new List<int> {500000, 200000, 100000, 50000};
            foreach (int i in t) {
                int temp;
                Console.Write("So to tien " + i + " can co: ");
                temp = tien / i;
                tien -= i * temp;
                Console.WriteLine(temp);
            }
            Console.WriteLine("So tien le con lai: " + tien);
        }
    }
}
