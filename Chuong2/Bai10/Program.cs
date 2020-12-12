using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int gio, phut,n;
            const int MAX = 60;
            const int SIXTY=60;
            string strgn;
            Console.WriteLine("Nhap vao so phut:");
            strgn = Console.ReadLine();
            int.TryParse(strgn, out n);
            gio = n / MAX;
            phut=(n%MAX)%SIXTY;
            Console.WriteLine("{0} Phut becomes {1} gio {2} phut" ,n,gio,phut);
            Console.ReadKey();
        }
    }
}
