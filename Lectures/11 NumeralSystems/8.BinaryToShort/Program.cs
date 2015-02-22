using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BinaryToShort
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number between[{0}; {1}]: ", short.MinValue, short.MaxValue);
            short number = short.Parse(Console.ReadLine());

            Console.WriteLine("{0} -> {1}", number, ConvertToBinary(number));
        }

        static string ConvertToBinary(int number)
        {
            string binary = string.Empty;
            for (int i = 15; i >= 0; i--)
            {
                binary = ((number % 2) & 1) + binary;
                number >>= 1;

                if (i % 4 == 0)
                {
                    binary = " " + binary;
                }
            }

            return binary;
        }
    }
}
