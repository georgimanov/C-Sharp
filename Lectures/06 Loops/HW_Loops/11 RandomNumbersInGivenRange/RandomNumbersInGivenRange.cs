/*
Problem 11.	Random Numbers in Given Range
Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. Examples:
n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note that the above output is just an example. Due to randomness, your program most probably will produce different results.
*/

using System;
class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Random number = new Random();
        Console.WriteLine("Ente n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ente min:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Ente max:");
        int max = int.Parse(Console.ReadLine());
        if (min <= max)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", number.Next(min, max + 1));
            }
        }
        else
        {
            Console.WriteLine("Wrong input min({0}) > max({0})", min, max );
        }
        Console.WriteLine();

    }
}