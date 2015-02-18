/*
Problem 9.	Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 
*/

using System;
class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        double input;
        double sum = 0.00d;
        for (int i = 0; i < n; i++)
        {
            input = double.Parse(Console.ReadLine());
            sum += input;
        }
        Console.WriteLine("Sum = {0:F2}",sum);
    }
}