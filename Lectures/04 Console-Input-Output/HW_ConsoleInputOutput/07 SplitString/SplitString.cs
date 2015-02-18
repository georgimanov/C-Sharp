/*
Problem 7.	Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. Examples: //how to split
numbers	    sum		numbers	        sum		numbers	            sum
1 2 3 4 5	15		10 10 10 10 10	50		1.5 3.14 8.2 -1 0	11.84
*/

using System;
class SplitString
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        
        double sum = 0.00d;
        
        string[] strArray = str.Split(' '); //separates the string wiht char ' ' and returns an array.
        
        foreach (var number in strArray)
        {
            sum += double.Parse(number); //Parse each number to double and add to the sum
        }
        Console.WriteLine(sum);
    }
}