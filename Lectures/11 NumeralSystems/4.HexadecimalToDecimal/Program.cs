using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            hex = hex.ToUpper();
            Console.WriteLine(HexToDecimal(hex));
        }
        static long HexToDecimal(string hex)
        {
            long decimalNumber = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                int digit = 0;
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    digit = hex[i] - '0';
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    digit = hex[i] - 'A' + 10; 
                } 

                int position = hex.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(16, position);
            }

            return decimalNumber; 

        }

    }
}
