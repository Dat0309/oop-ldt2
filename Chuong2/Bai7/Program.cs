using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4000000,
                b = 5000000,
                c = 3000000,
                d, e, f;
            
           //Xuat luong cua 3 nhan vien
            Console.WriteLine("Luong cua nhan vien 1={0} , nhan vien 2={1} , nhan vien 3={2}", a, b, c);
            d = (a * 4 / 100) + a;
            e = (b * 4 / 100) + b;
            f = (c * 4 / 100) + c;
            Console.WriteLine("Muc Luong cua 3 nhan vien sau 1 nam la:");
            Console.WriteLine("Nhan vien 1={0} , nhan vien 2={1} , nhan vien 3={2}", d,e,f);
            Console.ReadKey();

        }
    }
}
