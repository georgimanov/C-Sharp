/*
Problem 2.	Prime Checker
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
n	            IsPrime(n)
0	            false
1	            false
2	            true
3	            true
4	            false
5	            true
323	            false
337	            true
6737626471	    true
117342557809	false
*/

using System;

class PrimeChecker
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(  isPrime(number));
    }

    public static bool isPrime(long number)
    {
        double boundary = Math.Sqrt(number);

        if (number == 0) return false;
        if (number == 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= boundary; ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}