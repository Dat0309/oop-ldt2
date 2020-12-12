using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random SoXoRanDum = new Random();
            int SoXo1,SoXo2,SoXo3;
            SoXo1 = SoXoRanDum.Next(1, 5);
            SoXo2 = SoXoRanDum.Next(1, 5);
            SoXo3 = SoXoRanDum.Next(1, 5);
            Console.WriteLine(SoXo1);
            Console.WriteLine(SoXo2);
            Console.WriteLine(SoXo3);
            int Doan1, Doan2, Doan3;
            string strg1, strg2, strg3;
            Console.WriteLine("Nhap vao so Doan thu nhat : ");
            strg1 = Console.ReadLine();
            int.TryParse(strg1, out Doan1);
            Console.WriteLine("Nhap vao so Doan thu 2 : ");
            strg2 = Console.ReadLine();
            int.TryParse(strg2, out Doan2);
            Console.WriteLine("Nhap vao so Doan thu 3 : ");
            strg3 = Console.ReadLine();
            int.TryParse(strg3, out Doan3);

            if ((Doan1 == SoXo1 &&Doan2 != SoXo2 && Doan3 != SoXo3)||(Doan1!=SoXo1&&Doan2==SoXo2&&Doan3!=SoXo3)||(Doan1!=SoXo1&&Doan2!=SoXo2&&Doan3==SoXo3))
            {Console.WriteLine("Doan dung 1 so, Tien thuong cua ban la $10");}
            else if ((Doan1 == SoXo1 && Doan2 == SoXo2 && Doan3 != SoXo3) || (Doan1 == SoXo1 && Doan2 != SoXo2 && Doan3 == SoXo3) || (Doan1 != SoXo1 && Doan2 == SoXo2 && Doan3 == SoXo3))
            { Console.WriteLine("Doan dung 2 so, Tien thuong cua ban la $100"); }
            else if (Doan1 == SoXo1 && Doan2 == SoXo2 && Doan3 == SoXo3)
            { Console.WriteLine("Doan dung 3 so theo thu tu chinhx xac, Tien thuong cua ban la $10.000"); }
            else if ((Doan1 == SoXo1 || Doan1 == SoXo2 || Doan1 == SoXo3) && (Doan2 == SoXo1 || Doan2 == SoXo2 || Doan2 == SoXo3) && (Doan3 == SoXo1 || Doan3 == SoXo2 || Doan3 == SoXo3))
            { Console.WriteLine("Doan dung 3 so khong theo thu tu, Tien thuong cua ban la $1000"); 
            }
            else
            { Console.WriteLine("Khong doan dung so nao!"); }
            Console.ReadKey();
        }
    }
}
