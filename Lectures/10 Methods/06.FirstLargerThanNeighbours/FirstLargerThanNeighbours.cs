/*Problem 6. First larger than neighbours

    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.

 */

using System;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array of integers[1 2 5 7 3 1 2 6 3]");
        string input = Console.ReadLine();

        string[] myStringArr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[myStringArr.Length];

        for (int i = 0; i < myStringArr.Length; i++)
        {
            numbers[i] = int.Parse(myStringArr[i]);
        }

        int firstGreater = GetFirstLargerThanNeighbours(numbers);

        Console.WriteLine("First Larger Than Neighbours is {0}", firstGreater);
    }

    private static int GetFirstLargerThanNeighbours(int[] numbers)
    {
        int number = -1;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                number = numbers[i];
                break;
            }
        }

        return number;
    }
}