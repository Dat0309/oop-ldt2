using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            float tich;
            int so;
            Console.WriteLine("Moi nhap mot so nguyen: ");
            int.TryParse(Console.ReadLine(), out so);
            for (int i = 1; i < 11; i++)
            {
                tich = so * i;
                Console.WriteLine("Tich cua so {0} * {1} = {2}", so, i, tich);
            }
            Console.ReadLine();
        }
    }
}
