using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, sum;
            Console.WriteLine("Tat ca so hoa hao tu 1 den 10.000 la: ");
            for(num=1;num<=1000;num++)
            {
                sum = 0;
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                        if (sum == num)
                            Console.WriteLine(num);
                    }
                }
            }
        }
    }
}
