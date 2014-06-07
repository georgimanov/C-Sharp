/*
Problem 10.	Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. Examples: 
n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
*/

using System;
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());

        ulong first = 0;
        ulong second = 1;
        ulong result;

        if(n <= 0)
        {
            Console.Write("Wrong input!");
        }
        else if (n == 1)
        {
            Console.Write("{0} ", first);
        }
        else
        {
            Console.Write("{0} ", first);
            Console.Write("{0} ", second);

            for (int i = 1; i < n - 1; i++)
            {
                result = first + second;
                Console.Write("{0} ", result);
                first = second;
                second = result;
            }
        }
        Console.WriteLine();
    }
}