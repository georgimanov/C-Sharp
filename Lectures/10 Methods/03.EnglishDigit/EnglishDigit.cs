/*Problem 3. English digit

    Write a method that returns the last digit of given integer as an English word.

Examples:
input 	output
512 	two
1024 	four
12309 	nine
*/

using System;

class EnglishDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number : ");
        string number = Console.ReadLine();
        char digit = number[number.Length - 1];
        Console.WriteLine(GetDigitName(digit));
    }

    private static string GetDigitName(char digit)
    {
        int number = digit - '0';

        switch (number)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 0: return "zero";
            default: return "not a digit";
        }
    }
}