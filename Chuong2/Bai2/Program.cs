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
            bool a,b,c,d,e,f,g,h,i,j;
            a = 5 > 4;
            b = 3 <= 3;
            c = 2 + 4 > 5;
            d = 6 == 7;
            e = 2 + 4 <= 6;
            f = 3 + 4 == 4 + 3;
            g = 1 != 2;
            h = 2 != 2;
            i = -5 == 7 - 2;
            j = 3 + 9 <= 0;
            Console.WriteLine("a =" +a);
            Console.WriteLine("b="+b);
            Console.WriteLine("c="+c);
            Console.WriteLine("d="+d);
            Console.WriteLine("e="+e);
            Console.WriteLine("f="+f);
            Console.WriteLine("g="+g);
            Console.WriteLine("h="+h);
            Console.WriteLine("i="+i);
            Console.WriteLine("j="+j);
            Console.ReadKey();
        }
    }
}
