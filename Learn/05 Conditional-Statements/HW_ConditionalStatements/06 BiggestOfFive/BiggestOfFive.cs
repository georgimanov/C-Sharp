/*
Problem 6.	The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements. Examples:
a	    b	    c	    d	    e	    biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5	0	    5	    5	    5
-3	    -0.5	-1.1	-2	    -0.1	-0.1
*/

using System;
class BiggestOfFive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st number ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 4th number ");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 5th number ");
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("{0} is the biggest", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("{0} is the biggest", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("{0} is the biggest", c);
        }
        else if (d > a && d > b && b > c && b > e)
        {
            Console.WriteLine("{0} is the biggest", d);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("{0} is the biggest", e);
        }
    }
}