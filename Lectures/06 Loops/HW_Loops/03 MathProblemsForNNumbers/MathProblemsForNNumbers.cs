/*
Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. Examples:
input	output		
3       min = 1
2       max = 5
5       sum = 8
1	    avg = 2.67

input	output
2       min = -1
-1      max = 4
4       sum = 3	
        avg = 1.50
*/

using System;
using System.Collections.Generic;

class MathProblemsForNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Eneter n: ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int[] numbersInput = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for number[{0}] : ", i);
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        numbers.Sort();
        Console.WriteLine("min = {0}", numbers[0]);
        numbers.Reverse();
        Console.WriteLine("max = {0}", numbers[0]);

        decimal sum = 0m;
        foreach (var num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("sum = {0}", sum);

        Console.WriteLine("avg = {0:F2}", (double)(sum / numbers.Count));
    }
}



