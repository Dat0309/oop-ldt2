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
            int x=0;
            int so, tong = 0;
            
            while (x>=0)
            {
                Console.WriteLine("Nhap vao cac so nguyen ngau nhien:");
                int.TryParse(Console.ReadLine(), out so);
                tong = tong + so;
                if (so == 999)
                {
                    x -= 1;
                    break;
                }
            }
            Console.WriteLine("Tong cua cac so nguyen vua nhap la: {0} ", tong-999);
            Console.ReadLine();
        }
    }
}
