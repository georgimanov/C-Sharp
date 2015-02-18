//15 Write a program to read your age from the console and print how old you will be after 10 years.

using System;
class AgeAfterTernYears
{
    static void Main(string[] args)
    {
        Console.Write("Your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(age + 10);
    }
}

