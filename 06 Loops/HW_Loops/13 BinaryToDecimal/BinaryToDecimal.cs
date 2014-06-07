/*
Problem 13.	Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:
binary	                        decimal
0	                            0
11	3
1010101010101011	            43691
1110000110000101100101000000	236476736
*/

using System;
class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter binary number");
        long decimalNumber = 0;
        string inputStr = Console.ReadLine();

        for (int i = inputStr.Length - 1, j = 0; i >= 0 ; i--, j++)
        {
            char currentChar = inputStr[i];
            if (currentChar == '1')
            {
                decimalNumber += (long)Math.Pow(2, j);
            }
        }
        Console.WriteLine(decimalNumber);
    }
}