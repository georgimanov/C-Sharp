/*
Problem 11.	* Numbers in Interval Dividable by Given Number
Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. Examples:
start	end	p	Comments
17	    25	2	20, 25
5	    30	6	5, 10, 15, 20, 25, 30
3	    33	6	5, 10, 15, 20, 25, 30
3	    4	0	-
99	    120	5	100, 105, 110, 115, 120
107	    196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
*/

using System;
class NumbersDividableBy5InInterval
{
    static void Main(string[] args)
    {
        Console.Write("Enter first positive integer number : ");
        int startNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second positive integer number : ");
        int endNum = int.Parse(Console.ReadLine());

        int p = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if( i % 5 ==0)
            {
                p++;
            }
        }
        Console.WriteLine("Result : {0}",p);
    }
}