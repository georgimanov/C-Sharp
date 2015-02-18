/*
Problem 7.
Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:
 
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 

 * Examples:
 
n	k	n! / (k! * (n-k)!)	   
3	2	3	   
4	2	6	   
10 	6	210	   
52	5	2598960	 
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        long k = long.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            double sum = CalculateFactoriel(n) / (CalculateFactoriel(k) * CalculateFactoriel(n - k));
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }

    private static double CalculateFactoriel(long n)
    {
        double nFactoriel = 1;
        for (long i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }
        return nFactoriel;
    }    
}
