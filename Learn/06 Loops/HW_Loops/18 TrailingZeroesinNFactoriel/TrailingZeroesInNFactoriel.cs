/*
Problem 18.	* Trailing Zeroes in N!
Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. Examples:
n	        trailing zeroes of n!	    explaination
10	        2	                        3628800
20	        4	                        2432902008176640000
100000	    24999	                    think why
*/

using System;
using System.Numerics;

class TrailingZeroesInNFactoriel
{
    static void Main(string[] args)
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger numberFactoriel = CalculateFactoriel(number);
        string trailingZeroes = numberFactoriel.ToString();
        Console.WriteLine(trailingZeroes);
        int countZeroes = 0;
        
        for (int i = trailingZeroes.Length, j = 0 ;i>0 ;j++, i--)
        {
            
            if ((trailingZeroes[trailingZeroes.Length - j - 1] == '0'))
            {
                countZeroes++;  
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(countZeroes);
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