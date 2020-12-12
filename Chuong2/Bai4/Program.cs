using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3;
            double b;
            b = a / 0.39370;
            Console.WriteLine("a={0} inch => b={1} cm", a,b);
            Console.ReadKey();
        }
    }
}
