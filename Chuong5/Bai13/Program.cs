using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, soAm = 0,cons=0;
            string strg;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nhap vao mot cum tu: ");
            strg = Console.ReadLine();
            for (i=0;i<strg.Length;i++)
            {
                if (strg[i]=='a'||strg[i]=='i'||strg[i]=='o'||strg[i]=='e'||strg[i]=='u'||strg[i]=='A'||strg[i]=='E'||strg[i]=='I'||strg[i]=='O'||strg[i]=='U')
                {
                    soAm++;
                }
                else if (strg[i]>='a' && strg[i]<='z'||strg[i]>='A'&&strg[i]<='Z')
                {
                    cons++;
                }
            }
            Console.WriteLine("Ky tu nguyen am co trong chuoi vua nhap la: {0}", soAm);
            Console.WriteLine("ky tu khong phai nguyen am trong chuoi vua nhap la: {0}", cons);
            Console.ReadLine();
        }
    }
}
