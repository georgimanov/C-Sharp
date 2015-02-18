/*
Problem 8.	Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula:
  
Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
* 
n	Catalan(n)
0	1
5	42
10	16796
15	9694845

*/
using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        
        BigInteger sum = CalculateFactoriel(2 * n) / (CalculateFactoriel(n + 1) * CalculateFactoriel(n));
        Console.WriteLine(sum);
    }

    private static BigInteger CalculateFactoriel(BigInteger n)
    {
        BigInteger nFactoriel = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }
        return nFactoriel;
    }    
}
