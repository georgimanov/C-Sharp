/*
Problem 5.	Sorting Numbers
Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
*/

using System;

class SortingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("enter number {0}", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}