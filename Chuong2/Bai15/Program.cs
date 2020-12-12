using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C, kq;
            string strgF;
            Console.WriteLine("Nhap vo nhiet do can doi:");
            strgF = Console.ReadLine();
            double.TryParse(strgF, out F);
            C = (F - 32) * 5 / 9;
            kq = Math.Round(C, 1);
            Console.WriteLine("{0} F = {1} C", F, kq);
            Console.ReadKey();
        }
    }
}
