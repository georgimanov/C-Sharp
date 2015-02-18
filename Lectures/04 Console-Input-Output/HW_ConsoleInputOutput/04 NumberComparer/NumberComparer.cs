/*
Problem 4.	Number Comparer
Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. Examples:
a	B	greater
5	6	6
10	5	10
0	0	0
-5	-2	-2
1.5	1.6	1.6
*/

using System;
class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        string str = Console.ReadLine();
        double a = double.Parse(str);
    
        Console.Write("Enter second number: ");
        str = Console.ReadLine();
        double b = double.Parse(str);

        double greaterAB = Math.Max(a, b);
        Console.WriteLine("{0} is greater",greaterAB);
    }
}