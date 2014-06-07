/*
Problem 17.	* Calculate GCD
Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet). Examples:
a	    b	    GCD(a, b)
3	    2	    1
60	    40	    20
5	    -15	    5
*/

using System;
class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());
        int c = 1;
        
        if (a < 0) { a *= -1; }
        if (b < 0) { b *= -1; }
        if (a < b)
        {
            c = a;
            a = b;
            b = c;
        }
        while (b != 0)
        {
            c = b;
            b = Math.Abs( a - b );
            a = c;
        }
        Console.WriteLine(a);
    }
}