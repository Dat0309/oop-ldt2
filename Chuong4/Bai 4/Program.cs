using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Bao;
            string strgBao;
            Console.WriteLine("Nhap vao suc gio cua con bao: ");
            strgBao = Console.ReadLine();
            int.TryParse(strgBao, out Bao);
            if (Bao >=157)
            {
                Console.WriteLine("Bao Cap 5!");
                
            }
            else if( Bao >=130)
            {
                Console.WriteLine("Bao cap 4!");
            }
            else if(Bao >=111)
            {
                Console.WriteLine("Bao Cap 3!");
            }
            else if (Bao >96)
            {
                Console.WriteLine("Bao cap 2!");
            }
            else if(Bao >74)
            {
                Console.WriteLine("Bao cap 1!");

            }
            else 
                Console.WriteLine("Khong phai la mot con bao!");
            Console.ReadKey();
        }
    }
}
