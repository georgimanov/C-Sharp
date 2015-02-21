using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int number = 200;
        PrintNFactorialToNumber(number);
    }

    private static void PrintNFactorialToNumber(int endIndex)
    {
        BigInteger result = new BigInteger();
        result = 1;

        for (int i = 1; i <= endIndex; i++)
        {
            result *= i;
            Console.WriteLine(result);
        }
    }
}