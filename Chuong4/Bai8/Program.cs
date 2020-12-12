using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random keoBuaBaoRandum = new Random();
            int KeoBuaBao;
            KeoBuaBao = keoBuaBaoRandum.Next(1,4);
            int Play;
            string strg;
            Console.WriteLine("Nhap 1(KEO) hoac 2(BUA) hoac 3(BAO) De choi tro choi");
            strg = Console.ReadLine();
            int.TryParse(strg, out Play);
            if (Play < 1 || Play > 3)
            {
                Console.WriteLine("Nhap sai");
            }
            else if (Play == 1)
                Console.WriteLine("Ban Da chon KEO!");
            else if (Play == 2)
                Console.WriteLine("Ban Da chon Bua!");
            else if (Play == 3)
                Console.WriteLine("Ban Da chon Bao!");

            if (Play == KeoBuaBao)
            {
                Console.WriteLine("HOA!");
            }
            else if (Play == 1 && KeoBuaBao == 2)
                Console.WriteLine("May ra BUA, ban da thua");
            else if (Play == 1 && KeoBuaBao == 3)
                Console.WriteLine("May ra BAO, ban da thang");
            else if (Play == 2 && KeoBuaBao == 1)

                Console.WriteLine("May ra KEO, ban da thang");

            else if (Play == 2 && KeoBuaBao == 3)
                Console.WriteLine("May ra BAO, ban da thua");
            else if (Play == 3 && KeoBuaBao == 1)
                Console.WriteLine("May ra KEO, ban da thua");
            else if (Play == 3 && KeoBuaBao == 2)
                Console.WriteLine("May ra BUA, ban da thang");

            Console.ReadKey();
        }
    }
}
