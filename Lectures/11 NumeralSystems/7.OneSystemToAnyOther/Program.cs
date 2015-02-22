using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            long number = rand.Next(0, int.MaxValue );
            Console.WriteLine(number);
            Console.WriteLine("Decimal: {0}",DecimalToBase(number, 28));
            Console.WriteLine("Number: {0}",BaseToDecimal(number.ToString(), 28));
            Console.WriteLine(BaseToDecimal(DecimalToBase(number, 28), 28));
        }
        static string DecimalToBase(long decimalNumber, int numeralSystem)
        {
            string result = String.Empty;

            while (decimalNumber > 0)
            {
                long digit = decimalNumber % numeralSystem;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }

                decimalNumber /= numeralSystem;
            }

            return result;
        }

        static long BaseToDecimal(string number, int numeralSystem)
        {
            long decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }

                int position = number.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(numeralSystem, position);
            }

            return decimalNumber;

        }
    }
}
