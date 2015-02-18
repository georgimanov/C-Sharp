/*
Problem 16.	Decimal to Hexadecimal Number
Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. Examples:
decimal	        hexadecimal
254	            FE
6883	        1AE3
338583669684	4ED528CBB4
*/

using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter decimal number");
        long inputNumber = long.Parse(Console.ReadLine());
        long hexadecimalNumber = inputNumber;
        long number = 0;

        StringBuilder hexadecimalString = new StringBuilder();

        while (inputNumber != 0)
        {
            if (inputNumber % 16 == 0)
            {
                hexadecimalString.Append("0");
            }
            else
            {
                number = (inputNumber % 16);
                switch (number)
                {
                    case 1:  hexadecimalString.Append("1"); break;
                    case 2:  hexadecimalString.Append("2"); break;
                    case 3:  hexadecimalString.Append("3"); break;
                    case 4:  hexadecimalString.Append("4"); break;
                    case 5:  hexadecimalString.Append("5"); break;
                    case 6:  hexadecimalString.Append("6"); break;
                    case 7:  hexadecimalString.Append("7"); break;
                    case 8:  hexadecimalString.Append("8"); break;
                    case 9:  hexadecimalString.Append("9"); break;
                    case 10: hexadecimalString.Append("A"); break;
                    case 11: hexadecimalString.Append("B"); break;
                    case 12: hexadecimalString.Append("C"); break;
                    case 13: hexadecimalString.Append("D"); break;
                    case 14: hexadecimalString.Append("E"); break;
                    case 15: hexadecimalString.Append("F"); break;

                    default:
                        break;
                }
            }
            inputNumber /= 16;
        }

        StringBuilder reversedArray = new StringBuilder(hexadecimalString.Length);
        for (int j = hexadecimalString.Length; j > 0; j--)
        {
            reversedArray.Append(hexadecimalString[j - 1]);
        }

        Console.WriteLine("{0} (10) = {1} (16) ", hexadecimalNumber, reversedArray);
    }
}