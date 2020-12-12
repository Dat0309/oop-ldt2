using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strg;
            Console.WriteLine("Nhap vao Tin nhan: ");
            strg = Console.ReadLine();
            if (strg.Length < 140)
            {
                Console.WriteLine("Tin nhan hop le!");
            }
            else
                Console.WriteLine("Tin nhan khong hop le!");
            Console.ReadKey();

        }
    }
}
