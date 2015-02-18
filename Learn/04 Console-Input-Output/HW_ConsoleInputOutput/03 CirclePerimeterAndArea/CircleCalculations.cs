/*
Problem 3.	Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples: 
r	    perimeter	    area
2	    12.57	        12.57
3.5	    21.99	        38.48
*/

using System;
class CircleCalculations
{
    static void Main(string[] args)
    {
        Console.Write("Enter radis: ");
        string str = Console.ReadLine();
        double radius = double.Parse(str);
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("Circle perimeter : {0:F2}",perimeter);
        Console.WriteLine("Circle are : {0:F2}", area);

    }
}