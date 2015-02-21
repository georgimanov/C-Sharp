/*Problem 8. Number as array

    Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.
 * 
 * 0 1 2 3 4 5 6 7
 * 5 4 2 1 5         51'245
 * 4 5 6 1         +  1'654
 *                   ------
 *                   52'899
 */

using System;
class NumberAsArray
{
    static void Main(string[] args)
    {
        char[] digitsOne = { '5', '4', '2', '1', '5' };
        char[] digitsTwo = { '4', '5', '6', '1' };
        int numberOne = GetNumber(digitsOne);
        int numberTwo = GetNumber(digitsTwo);

        int sum = AddTwoNumbers(numberOne, numberTwo);
        Console.WriteLine("Sum {0}", sum);
    }

    private static int AddTwoNumbers(int numberOne, int numberTwo)
    {
        return numberTwo + numberOne;
    }

    private static int GetNumber(char[] digitsOne)
    {
        int lenght = digitsOne.Length;
        String numberAsStr = String.Empty;
        while(lenght > 0){
            numberAsStr += digitsOne[lenght - 1];
            lenght--;
        }

        return int.Parse(numberAsStr);

    }
}