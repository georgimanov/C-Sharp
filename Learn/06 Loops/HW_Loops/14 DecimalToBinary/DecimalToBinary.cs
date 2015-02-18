/*
Problem 14.	Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. Examples:
decimal	    binary
0	        0
3	        11
43691	    1010101010101011
236476736	1110000110000101100101000000
*/

using System;
using System.Text;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter decimal number");
        long inputNumber = long.Parse(Console.ReadLine());
        long decimalNumber = inputNumber;

        StringBuilder binaryStr = new StringBuilder();

        while (inputNumber != 0)
        {
            if (inputNumber % 2 == 0)
                binaryStr.Append("0");

            if (inputNumber % 2 != 0)
                binaryStr.Append("1");

            inputNumber /= 2;
        }

        StringBuilder reversedArray = new StringBuilder(binaryStr.Length);

        for (int j = binaryStr.Length; j > 0; j--)
        {
            reversedArray.Append(binaryStr[j - 1]);
        }

        Console.WriteLine("{0} (10) = {1} (2) ", decimalNumber, reversedArray);
    }
}