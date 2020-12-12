using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, kq;
            string strga;
            Console.WriteLine("Nhap luong cho Nhan vien, a= ");
            strga = Console.ReadLine();
            double.TryParse(strga, out a);
            kq = (a * 44 / 100) + a;
            Console.WriteLine("Luong cua nhan vien sau 1 nam la:{0}",kq);
            Console.ReadKey();
        }
    }
}
