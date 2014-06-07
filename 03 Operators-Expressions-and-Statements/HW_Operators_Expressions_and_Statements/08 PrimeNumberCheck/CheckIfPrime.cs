/*
 Problem 8
 * Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
*/

using System;
class CheckIfPrime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number N. For  0 < n <= 100");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = false;
        if (number == 2 ^ number == 3 ^ number == 5 ^ number == 7)
        {
            isPrime = true;
        }
        else
        {
            isPrime = (number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0);
        
        }
    
        Console.WriteLine("Is prime: {0}", isPrime);
    }
}