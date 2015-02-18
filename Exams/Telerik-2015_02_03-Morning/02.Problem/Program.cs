using System;

class Program
{
    static void Main(string[] args)
    {
        int salt = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        decimal result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char symbol = input[i];
            if (symbol == '@')
            {
                break;
            }

            if (Char.IsLetter(symbol))
            {
                result = ((int)symbol * salt) + 1000;
            }
            else if ((Char.IsDigit(symbol)))
            {
                result = ((int)symbol + salt) + 500;
            }
            else
            {
                result = (int)symbol - salt;
            }

            if (i % 2 == 0)
            {
                result /= 100;
                Math.Round(result, 2);
                Console.WriteLine("{0:0.00}", result);
            }
            else
            {
                result *= 100;
                Console.WriteLine("{0}", result);
            }

            result = 0;
        }
    }
}