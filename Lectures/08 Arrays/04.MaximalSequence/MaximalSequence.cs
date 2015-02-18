using System;

class MaximalSequence
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string [example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
        string input = Console.ReadLine();
        char[] delimiter = { ',' };
        string[] strArr = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] intArr = new int[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            intArr[i] = int.Parse(strArr[i]);
        }

        int indexStart = 0;
        int maxSequence = 1;

        for (int i = 0; i < intArr.Length - 1; i++)
        {
            int currentSequence = 1;
            for (int j = i; j < intArr.Length - 1; j++)
            {
                if (intArr[j] == intArr[j + 1])
                {
                    currentSequence++;
                }
                else
                {
                    break;
                }
            }

            if (currentSequence >= maxSequence)
            {
                indexStart = i;
                maxSequence = currentSequence;
            }
        }

        Console.WriteLine("Index start: " + indexStart);
        Console.WriteLine("Max sequence: " + maxSequence);
        Console.Write("Sequence: ");
        for (int i = indexStart; i < maxSequence + indexStart; i++)
        {
            Console.Write(intArr[i]);
            if (i != maxSequence + indexStart - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}