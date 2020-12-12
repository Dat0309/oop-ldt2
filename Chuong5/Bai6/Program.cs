using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            float tich;
            int i=1;
            for (i = 1; i <10;i++ )
            {
                for (int j=2;j<10;j++)
                {
                    tich = i * j;
                    Console.WriteLine("{0}*{1}={2}", i, j, tich);
                }
            }
                Console.ReadLine();

        }
    }
}
