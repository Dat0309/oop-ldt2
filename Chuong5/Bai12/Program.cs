using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInphutString;
            string userInput;
            string www = "www";
            string com = ".com";

            Console.WriteLine("Nhap ten doanh nghiep cua ban!");
            userInphutString = Console.ReadLine();
            while (userInphutString.IndexOf(" ") > 0)
            {
                userInphutString = userInphutString.Replace(" ", "");
            }
            userInput = userInphutString;
            Console.WriteLine(www + userInput + com);
            Console.ReadLine();
        }
    }
}
