using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinnerPrince = 10.00,tipRate,tip;
            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;
            Console.WriteLine("   Prince");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Console.WriteLine("{0,8}", tipRate.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            tipRate = LOWRATE;
            while (dinnerPrince <= MAXDINNER)
            {
                Console.Write("{0, 8}", dinnerPrince.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrince * tipRate;
                    Console.Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrince += DINNERSTEP;
                tipRate = LOWRATE;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
