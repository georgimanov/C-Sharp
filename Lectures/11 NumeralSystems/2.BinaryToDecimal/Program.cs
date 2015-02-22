using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(number));
        }

        static long BinaryToDecimal(string binaryNumber)
        {
            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                // int digit = binaryNumber[i] == '1'? 1 : 0;
                int digit = binaryNumber[i] - '0';
                int position = binaryNumber.Length - i - 1;
                decimalNumber += digit *  (long) Math.Pow(2, position);
            }

            return decimalNumber;
        }
    }
}
