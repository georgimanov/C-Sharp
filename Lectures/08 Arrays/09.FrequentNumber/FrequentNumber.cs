using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string [example: 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]");
        string input = Console.ReadLine();

        // Comment left for testing purposes only
        // string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";
        // Console.WriteLine(input);

        char[] delimiter = { ',' };
        string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] myArr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            myArr[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine(String.Join(", ", myArr));

        int mostFrequentNumber = myArr[0];
        int counter = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            int currentCounter = 1;
            for (int j = i + 1; j < myArr.Length; j++)
            {
                if (myArr[i] == myArr[j])
                {
                    currentCounter++;
                }
            }
            if (currentCounter > counter)
            {
                mostFrequentNumber = myArr[i];
                counter = currentCounter;
            }
        }
        Console.WriteLine("{0} ({1} times)", mostFrequentNumber, counter);
    }
}