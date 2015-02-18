using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array's lenght N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter lenght of subset elements K:");
        int k = int.Parse(Console.ReadLine());

        if (n < k)
        {
            Console.WriteLine("The length of subset elements must be smaller or equal than the array's length!");
            return;
        }

        Console.WriteLine("Enter array [example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
        string input = Console.ReadLine();
        char[] delimiter = { ',' };
        string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] myArr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            myArr[i] = int.Parse(inputArray[i]);
        }

        int bestSum = int.MinValue;
        int index = 0;
        for (int i = 0; i <= myArr.Length - k ; i++)
        {
            int currentBestSum = 0;
            for (int j = i; j < i + k; j++)
            {
                currentBestSum += myArr[j];
            }

            if (currentBestSum > bestSum)
            {
                bestSum = currentBestSum;
                index = i;
            }
        }

        Console.WriteLine("Best sum is : {0}", bestSum);
        for (int i = index; i < index + k; i++)
        {
            Console.Write(myArr[i]);
            if (i < index + k - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
	}
}