using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, g, h, kq;
            double kq2;
            string mot, hai, ba, bon, nam, sau, bay, tam;
            Console.WriteLine("Nhap vao so diem kiem tra: ");
            mot = Console.ReadLine();
            double.TryParse(mot, out a);
            hai = Console.ReadLine();
            double.TryParse(hai, out b);
            ba = Console.ReadLine();
            double.TryParse(ba, out c);
            bon = Console.ReadLine();
            double.TryParse(bon, out d);
            nam = Console.ReadLine();
            double.TryParse(nam, out e);
            sau = Console.ReadLine();
            double.TryParse(sau, out f);
            bay = Console.ReadLine();
            double.TryParse(bay, out g);
            tam = Console.ReadLine();
            double.TryParse(tam, out h);

            kq = (a + b + c + d + e + f + g + h) / 8;
            kq2 = Math.Round(kq, 2);
            Console.WriteLine(kq2);
            Console.ReadKey();
        }
    }
}
