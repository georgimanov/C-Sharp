/*
Problem 1.	Sum of 3 Integers
Write a program that reads 3 integer numbers from the console and prints their sum. Examples:
a	b	c	sum
3	4	11	19
-2	0	3	1
5.5	4.5	20.1	30.1
*/

using System;
class SumInt
{
    static void Main(string[] args)
    {
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());
        int sum = firstInt + secondInt + thirdInt;
        Console.WriteLine(sum);
    }
}