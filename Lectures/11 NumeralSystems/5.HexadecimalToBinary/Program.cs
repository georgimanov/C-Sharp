using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(HexToBinary(hex));
        }

        static string HexToBinary(string hex)
        {
            return DecimalToBinary(HexToDecimal(hex));
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
        static string DecimalToBinary(long decimalNumber)
        {
            string binaryNumber = "";

            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber += digit;
                decimalNumber = decimalNumber / 2;
            }

            var numberAsCharArray = binaryNumber.ToCharArray();
            Array.Reverse(numberAsCharArray);
            binaryNumber = new string(numberAsCharArray);

            return binaryNumber;
        }

    }
}
