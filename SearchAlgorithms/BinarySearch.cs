using System;
class BinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string [example: 2, 3, -6, -1, 6, 4, -8, 8]");
        string input = Console.ReadLine();

        // Comment left for testing purposes only
        // string input = "2, 3, -6, -1, 6, 4, -8, 8";
        // Console.WriteLine(input);

        char[] delimiter = { ',' };
        string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] myArr = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            myArr[i] = int.Parse(inputArray[i]);
        }

        Array.Sort(myArr);

        // int number = 12;

        Console.WriteLine("Enter number : ");
        int number = int.Parse(Console.ReadLine());

        int index = BinarySearchIndex(myArr, number, 0, myArr.Length - 1);
        if (index < 0)
        {
            Console.WriteLine("Index not found");
        }
        else
        {
            Console.WriteLine("Index of given number in array is {0}", index);
        }
    }

    private static int BinarySearchIndex(int[] myArr, int key, int min, int max)
    {
        // test if array is empty
        if (max < min)
        {
            // set is empty, so return value showing not found
            return -1;
        }
        else
        {
            // calculate midpoint to cut set in half
            int middlePoint = MidPoint(min, max);

            // three-way comparison
            if (myArr[middlePoint] > key)
            {
                // key is in lower subset
                return BinarySearchIndex(myArr, key, min, middlePoint - 1);
            }
            else if (myArr[middlePoint] < key)
            {
                // key is in upper subset
                return BinarySearchIndex(myArr, key, middlePoint + 1, max);
            }
            else
            {
                // key has been found
                return middlePoint;
            }
        }
    }

    private static int MidPoint(int min, int max)
    {
        return min + ((max - min) / 2);
    }
}