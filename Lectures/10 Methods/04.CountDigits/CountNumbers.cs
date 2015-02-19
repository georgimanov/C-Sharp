/*Problem 4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.

 */

using System;
class CountNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string :");
        string input = Console.ReadLine();

        Console.WriteLine("Enter digit :");
        char digit = Char.Parse(Console.ReadLine());
        Console.WriteLine(CountDigitOcurrances(input, digit));
    }

    private static int CountDigitOcurrances(string input, char digit)
    {
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == digit)
            {
                counter++;
            }
        }
        return counter;
    }
}
