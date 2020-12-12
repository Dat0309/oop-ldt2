using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int twenties, tens, fives, ones,chuc,muoi,le,donvi, dollas;
            string Tongdola;
            Console.WriteLine("Nhap vo so dollas can chuyen doi :");
            Tongdola = Console.ReadLine();
            int.TryParse(Tongdola, out dollas);
            twenties = dollas / 20;
            chuc = dollas % 20;
            tens = chuc / 10;
            muoi = chuc % 10;
            fives = muoi / 5;
            le = muoi % 5;
            ones = le / 1;
            donvi = le % 1;
            Console.WriteLine("${0} Duoc chuyen doi thanh {1} twenties,{2} ten,{3} fives, and {4} ones", dollas, twenties, tens, fives, ones);
            Console.ReadKey();

        }
    }
}
