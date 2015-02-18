using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string [example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
        string input = Console.ReadLine();
        char[] delimiter = { ',' };
        string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] myArr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            myArr[i] = int.Parse(inputArray[i]);
        }


        for (int i = 0; i < myArr.Length; i++)
        {
            int index = 0;
            int min = int.MaxValue;
            for (int j = i; j < myArr.Length; j++)
            {
                if (min > myArr[j])
                {
                    min = myArr[j];
                    index = j;
                }
            }

            int temp = myArr[i];
            myArr[i] = myArr[index];
            myArr[index] = temp;
            Console.WriteLine(string.Join(", ", myArr));
            Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", myArr));
    }
}