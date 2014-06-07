//02 Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;
class Program
{
    static void Main(string[] args)
    {
        double fisrtVar = 34.567839023d;
        float secondVar = 12.345f;
        double thirdVar = 8923.1234857d;
        float forthVar = 3456.091f;
        Console.WriteLine(fisrtVar);
        Console.WriteLine(secondVar);
        Console.WriteLine(thirdVar);
        Console.WriteLine(forthVar);
    }
}