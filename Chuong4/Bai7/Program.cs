using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber,SoDoan;
            string strgDoan;
            randomNumber = ranNumberGenerator.Next(1, 11);
            
            Console.WriteLine("Xin moi doan so ngau nhien: ");
            strgDoan = Console.ReadLine();
            int.TryParse(strgDoan, out SoDoan);
            Console.WriteLine(randomNumber);
            if (SoDoan == randomNumber)
            {
                Console.WriteLine("Doan dung!");
            }
            else if (SoDoan > randomNumber)
                Console.WriteLine("So Doan qua cao!");
            else
                Console.WriteLine("So Doan qua thap!");
            Console.ReadKey();
            
        }
    }
}
