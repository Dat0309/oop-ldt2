using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Gia;
            string strgGia;
            Console.WriteLine("Nhap gia mua cho mot mat hang: ");
            strgGia = Console.ReadLine();
            uint.TryParse(strgGia, out Gia);
            if (Gia > 8000)
            {
                Console.WriteLine("ERROR");

            }
            else
                Console.WriteLine("APPROVED");
            Console.ReadKey();
        }
    }
}
