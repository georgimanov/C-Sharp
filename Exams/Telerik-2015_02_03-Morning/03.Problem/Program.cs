using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        BigInteger result = 1;
        BigInteger secondResult = 1;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string number = input;
            if (counter % 2 != 0 && counter <= 10)
            {
                if (number == "0")
                {
                    result *= 1;
                }
                else
                {
                    result *= ProductOfDigits(number);
                }
            }
            else if (counter % 2 != 0 && counter > 10)
            {
                if (number == "0")
                {
                    secondResult *= 1;
                }
                else
                {
                    secondResult *= ProductOfDigits(number);
                }
            }

            counter++;
        }

        Console.WriteLine(result);

        if (counter > 10)
        {
            Console.WriteLine(secondResult);
        }
    }

    private static long ProductOfDigits(string number)
    {
        long productOfDigits = 1;
        foreach (var symbol in number)
        {
            if (symbol != '0')
            {
                productOfDigits *= symbol - '0';
            }
        }

        return productOfDigits;
    }
}