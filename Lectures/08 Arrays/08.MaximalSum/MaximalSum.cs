using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string [example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
        string input = Console.ReadLine();
        
        // Comment left for testing purposes only
        // string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";
        // Console.WriteLine(input);

        char[] delimiter = { ',' };
        string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] myArr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            myArr[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine(String.Join(", ", myArr));

        int bestSum = int.MinValue;
        int counter = 1;
        int index = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            int currentSum = myArr[i];
            int currentCounter = 1;
            for (int j = i; j < myArr.Length - 1; j++)
            {
                currentSum += myArr[j + 1];
                currentCounter++;
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    index = i;
                    counter = currentCounter;
                }
            }
        }

        Console.WriteLine("Counter: {0}", counter);
        Console.WriteLine("BestSum: {0}", bestSum);
        Console.WriteLine("Start Index: {0}", index);

        for (int i = index; i < index + counter; i++)
        {
            Console.Write(myArr[i]);
            if (i < index + counter - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();

    }
}