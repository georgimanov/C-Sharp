/*
Problem 1.	Fibonacci Numbers

Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
n	Fib(n)
0	1
1	1
2	2
3	3
4	5
5	8
6	13
11	144
25	121393
*/

using System;
using System.Numerics;
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger FibN = 0;

        for (int i = 0; i < n; i++)
        {
            FibN = first + second;
            first = second;
            second = FibN;
        }
        Console.WriteLine("Fib({1}) = {0}", FibN, n );
    }
}