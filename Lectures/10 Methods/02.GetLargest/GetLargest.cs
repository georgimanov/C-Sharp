/*Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

using System;
class GetLargest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 numbers: ");
        Console.Write("Number 1 : ");
        long a = long.Parse(Console.ReadLine());

        Console.Write("Number 2 : ");
        long b = long.Parse(Console.ReadLine());

        Console.Write("Number 3 : ");
        long c = long.Parse(Console.ReadLine());

        long max = GetMax(a, GetMax(b,c));
        Console.WriteLine("The max number is {0}", max);
    }
    public static long GetMax(long a, long b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}