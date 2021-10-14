using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI08
{
    class PhanSo
    {
        private int tu;
        private int mau;
        public PhanSo(int a = 0, int b = 1)
        {
            tu = a;
            mau = b;
        }
        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }
        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }
        public void congPS(PhanSo a)
        {
            this.Tu = this.Tu * a.Mau + this.Mau * a.Tu;
            this.Mau = this.Mau * a.Mau;
            Console.WriteLine("Phep cong 2 phan so: " + this.Tu + "/" + this.Mau);
        }
        public void truPS(PhanSo a)
        {
            this.Tu = this.Tu * a.Mau - this.Mau * a.Tu;
            this.Mau = this.Mau * a.Mau;
            Console.WriteLine("Phep tru 2 phan so: " + this.Tu + "/"+ this.Mau);
        }
        public void nhanPS(PhanSo a)
        {
            this.Tu = this.Tu * a.Tu;
            this.Mau = this.Mau * a.Mau;
            Console.WriteLine("Phep nhan 2 phan so: " + this.Tu + "/" + this.Mau);
        }
        public void chiaPS(PhanSo a)
        {
            this.Tu = this.Tu * a.Mau;
            this.Mau = this.Mau * a.Tu;
            Console.WriteLine("Phep chia 2 phan so: " + this.Tu + "/" + this.Mau);
        }
        static void Main(string[] args)
        {
            PhanSo p = new PhanSo();
            PhanSo a = new PhanSo(2,3);
            p.congPS(a);
            p.truPS(a);
            p.nhanPS(a);
            p.chiaPS(a);
        }
    }
}
