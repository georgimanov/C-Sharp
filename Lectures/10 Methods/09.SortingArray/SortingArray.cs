/*
 * Problem 9. Sorting array

    Write a method that returns the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Collections.Generic;

class SortingArray
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 5, 7, 3, -10 , 11, 578, 32, 57, 1234, 6 };

        Console.WriteLine("Not sorted: " + String.Join(" ", numbers));

        SortArray(numbers, true);

        Console.WriteLine("Ascending : " + String.Join(" ", numbers));

        SortArray(numbers, false);

        Console.WriteLine("Descending: " + String.Join(" ", numbers));
    }

    public static void SortArray(List<int> numbers, bool ascending)
    {
        if (ascending)
        {
            SortAscending(numbers);
        }
        else
        {
            SortDescending(numbers);
        }
    }

    public static int GetMaxIndex(List<int> numbers, int indexStart, int indexEnd)
    {
        int maxIndex = 0;
        int maxNumber = int.MinValue;

        int lenghtArr = numbers.Count;

        if (indexStart >= 0 && 
            indexStart <= lenghtArr && 
            indexEnd >= 0 &&
            indexEnd <= lenghtArr)
        {
            for (int i = indexStart; i <= indexEnd; i++)
            {
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                    maxIndex = i;
                }
            }
        }
        else
        {
            return -1;
        }

        return maxIndex;
    }

    static void SortDescending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            Swap(numbers, i, GetMaxIndex(numbers, i, numbers.Count - 1));
        }
    }

    static void SortAscending(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++) 
        {
            Swap(numbers, numbers.Count - i - 1, GetMaxIndex(numbers, 0, numbers.Count - i - 1));
        }
    }
    
    public static void Swap(List<int> numbers, int i, int j)
    {
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }
}