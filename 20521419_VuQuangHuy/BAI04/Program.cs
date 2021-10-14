using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI04
{
    class Program
    {
        static void Main(string[] args)
        {
            int soMayMan = 0;
            Random soMayChon = new Random();
            int so;
            so = soMayChon.Next(0, 100);
            Console.WriteLine("Nhap so may man ma ban muon chon: ");
            do
            {   
                soMayMan = int.Parse(Console.ReadLine());
                if (soMayMan == so)
                {
                    Console.WriteLine("Xin chuc mung"); break;
                }
                else if (soMayMan < so)
                {
                    Console.WriteLine("So ban chon nho hon. Xin moi doan lai: ");
                }
                else
                {
                    Console.WriteLine("So ban chon lon hon. Xin moi doan lai: ");
                }

            } while (soMayMan != so);
        }
    }
}
