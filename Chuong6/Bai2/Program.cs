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
            int[] diem = new int[] { 5, 6, 7, 8, 9, 4, 3, 8 };
            float diemTB=(5+6+7+8+9+4+3+8)/8;
            Console.WriteLine("Diem trung binh cua tat ca hoc sinh la: ");
            Console.WriteLine(diemTB);
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine("Diem cua hoc sinh thu {0} la {1}", i + 1, diem[i]);
                    Console.WriteLine("Diem con cach xa diem trung binh la {0} diem.",diemTB-diem[i]);
                }
            Console.ReadLine();
        }
    }
}
