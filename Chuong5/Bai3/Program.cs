using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            string strg,strg2="!";
            int i = 0,x=1;
            {
                while (x > 0)
                {
                    Console.WriteLine("Nhap vao mot Ky tu viet hoa tu ban phim: ");
                    strg = Console.ReadLine();

                    while (i<1)
                    {
                        if (strg[i] >= 'A' && strg[i] <= 'Z')
                        {
                            Console.WriteLine("OK");
                        }
                        else
                            Console.WriteLine("ERROR");
                        break;
                    }
                    if (String.Compare(strg, strg2, true) == 0)
                        break;

                }
                Console.ReadLine();
            }

        }
    }
}
