/*
Problem 6.	Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:
n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/

using System;

class CalculateFactorielNK
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter n: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        long k = long.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            int factorielN = 1;
            int factorielK = 1;
            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (i <= k)
                {
                    factorielK *= i;
                }
                result = factorielN / factorielK;
            }
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}