using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinaryToHex(number));
        }

        static string BinaryToHex(string number)
        {
            return DecimalToHex(BinaryToDecimal(number));
        }

        static long BinaryToDecimal(string binaryNumber)
        {
            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i] - '0';
                int position = binaryNumber.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }

            return decimalNumber;
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
