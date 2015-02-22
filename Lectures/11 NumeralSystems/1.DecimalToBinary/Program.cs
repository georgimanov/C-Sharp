using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(number));
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
