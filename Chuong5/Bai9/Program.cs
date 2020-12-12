using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            float tong = 0;
            for (i=1;i<201;i++)
            {
                tong += i;
                if (i == 100)
                    Console.WriteLine("Tong cua 100 so dau tien la:{0} ", tong);
                else if (i == 200)
                    Console.WriteLine("Tong cua cac so tu 1 den 200 la:{0} ", tong);
            }
            Console.ReadLine();
        }
    }
}
