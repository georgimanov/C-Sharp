using System;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ProductOfDigits(123456));
    }
    private static BigInteger ProductOfDigits(BigInteger number)
    {
        BigInteger productOfDigits = 1;
        while (number > 0)
        {
            BigInteger currentDigit = number % 10;
            productOfDigits *= currentDigit;
            number /= 10;
        }
        return productOfDigits;
    }
}