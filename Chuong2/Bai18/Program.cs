using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, strkq,str4;
            Console.WriteLine("Nhap vao chu can chuyen doi sang ky tư PigLatin");
            str1 = Console.ReadLine();
            string str3 = str1;
            str2 = str1.Substring(1);
            str4 = str3.Substring(0,1);
            strkq = str2 + str4 + "ay";
            //Console.WriteLine(str2);
            //Console.WriteLine(str4);
            Console.WriteLine(strkq);
            Console.ReadKey();
        }
    }
}
