using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            float so, tong = 0;
            while(x<6)
            {
                Console.WriteLine("MOI NHAP SO THU : ");
                Console.WriteLine(x);
                float.TryParse(Console.ReadLine(), out so);
                tong = tong + so;
                x = x + 1;
            }
            Console.WriteLine("TONG CUA 5 SO LA: {0}", tong);
            Console.ReadLine();
        }
    }
}
