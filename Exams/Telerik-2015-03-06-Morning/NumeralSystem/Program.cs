using System;
using System.Numerics;

namespace NumeralSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] result = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                BigInteger catToDecimal = CatToDecimal(input[i]);
                result[i] = DecimalToHuman(catToDecimal);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        static BigInteger CatToDecimal(string number, int numeralSystem = 17)
        {
            BigInteger decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;

                if (Char.IsLetter(number[i]))
                {
                    digit = number[i] - 'a';
                }

                int position = number.Length - i - 1;
                decimalNumber += digit * BigInteger.Pow(numeralSystem, position);
            }

            return decimalNumber;
        }

        static string DecimalToHuman(BigInteger decimalNumber, int numeralSystem = 26)
        {
            string result = String.Empty;

            while (decimalNumber > 0)
            {
                BigInteger digit = decimalNumber % numeralSystem;
               
                result = (char)(digit + 'a') + result;

                decimalNumber /= numeralSystem;
            }

            return result;
        }
    }
}