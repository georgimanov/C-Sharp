/*
Problem 15.	Hexadecimal to Decimal Number
Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:
hexadecimal	    decimal
FE	            254
1AE3	        6883
4ED528CBB4	    338583669684
*/

using System;
class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter hexadecimal number");
        string inputStr  = Console.ReadLine();
        inputStr = inputStr.ToUpper();

        long number = 0;
        long decimalResult = 0;

        for (int i = inputStr.Length - 1, j = 0; i >= 0; i--, j++)
        {
            char currentChar = inputStr[i];
            if (currentChar != '0')
            {
                switch (currentChar)
                {
                    case '1': number = 1; break;
                    case '2': number = 2; break;
                    case '3': number = 3; break;
                    case '4': number = 4; break;
                    case '5': number = 5; break;
                    case '6': number = 6; break;
                    case '7': number = 7; break;
                    case '8': number = 8; break;
                    case '9': number = 9; break;
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break; 
                    default:
                        break;
                }
                decimalResult += (number * (long)Math.Pow(16, j));
            }
        }
        Console.WriteLine(decimalResult);
    }
}