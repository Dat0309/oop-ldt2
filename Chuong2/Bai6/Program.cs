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
            double b, a;
            Console.WriteLine("Nhap a=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri a vua nhap vao la {0} inch", a);

            b = a / 0.39370;
            Console.WriteLine("Gia tri sau khi doi qua Centimet la b={0} Centimet", b);
            Console.ReadKey();
        }
    }
}
