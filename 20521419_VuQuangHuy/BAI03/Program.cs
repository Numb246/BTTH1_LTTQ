using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gio vao ca: ");
            int gioVao = int.Parse(Console.ReadLine());
            while (gioVao < 6)
            {
                Console.WriteLine("Nhap sai. Moi nhap lai: ");
                gioVao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap gio ra ca: ");
            int gioRa = int.Parse(Console.ReadLine());
            while (gioRa > 18)
            {
                Console.WriteLine("Nhap sai. Moi nhap lai: ");
                gioRa = int.Parse(Console.ReadLine());
            }
            int tongGio = gioRa - gioVao;
            int tienLuong = 0;
            if (tongGio < 12)
            {
                tienLuong += tongGio * 6000;
            }
            else
            {
                tienLuong += tongGio * 7500;
            }
            Console.WriteLine("Tien luong ngay cua cong nhan: " + tienLuong);
        }
    }
}
