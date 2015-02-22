using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(number));
        }
        static string DecimalToHex(long decimalNumber)
        {
            string hex = String.Empty;

            while (decimalNumber > 0)
            {
                long digit = decimalNumber % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit - 10 + 'A') + hex;
                }

                decimalNumber /= 16;
            }

            return hex;
        }
    }
}
