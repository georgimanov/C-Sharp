/*Problem 14. Integer calculations

    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.
*/

using System;

class IntegerCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Average: {0}", GetAverage(1, 2, 3, 4));
        Console.WriteLine("Max: {0}", GetMax(1, 2, 3, 4));
        Console.WriteLine("Min: {0}", GetMin(1, 2, 3, 4));
        Console.WriteLine("Product: {0}", GetProduct(1, 2, 3, 4));
        Console.WriteLine("Sum: {0}", GetSum(1, 2, 3, 4));

    }

    static decimal GetAverage(params int[] arr)
    {
        decimal sum = 0;
        decimal average;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return average = (sum / arr.Length);
    }

    static int GetMax(params int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static int GetMin(params int[] arr)
    {
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    static int GetProduct(params int[] arr)
    {
        int product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }

    static int GetSum(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
}