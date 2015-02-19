/*Problem 5. Larger than neighbours

    Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

 */

using System;
using System.Collections.Generic;
class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array of integers[1 2 5 7 3 1 2 6 3]");
        string input = Console.ReadLine();

        string[] myStringArr = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[myStringArr.Length];
        
        for (int i = 0; i < myStringArr.Length; i++)
        {
            numbers[i] = int.Parse(myStringArr[i]);
        }

        Console.WriteLine("Enter position of type int");
        int position = int.Parse(Console.ReadLine());

        bool isGreaterThanNeighbours = isGrtrThanNeighbours(numbers, position);
        Console.WriteLine(isGreaterThanNeighbours);
    }

    private static bool isGrtrThanNeighbours(int[] numbers, int position)
    {
        bool isGreater = false;

        if (position > 0 && position < numbers.Length - 1)
        {
            if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
            {
                isGreater = true;
            }
        }
        else if (position == 0)
        {
            if (numbers[position] > numbers[position + 1])
            {
                isGreater = true;
            }
        }
        else if (position == numbers.Length - 1)
        {
            if (numbers[position] > numbers[position - 1])
            {
                isGreater = true;
            }
        }

        return isGreater;
    }
}