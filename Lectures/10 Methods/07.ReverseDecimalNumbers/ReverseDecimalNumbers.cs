/*Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.

Example:
input 	output
256 	652
123.45 	54.321
 */

using System;

class ReverseDecimalNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter decimal number: ");
        string input = Console.ReadLine();

        Console.WriteLine(String.Join("", Reverse(input)));
    }

    private static char[] Reverse(string input)
    {
        char[] output = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            output[i] = input[input.Length - 1 - i]; 
        }
        return output;
    }
}