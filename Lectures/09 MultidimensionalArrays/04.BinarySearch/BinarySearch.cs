using System;
class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter array lenght [N] : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter integer [K] : ");
        int maxNumber = int.Parse(Console.ReadLine());

        int[] myArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArr);
        Console.WriteLine("Soted array [{0}]", String.Join(", ", myArr));

        int index = Array.BinarySearch(myArr, maxNumber);

        if (!(Array.BinarySearch(myArr, maxNumber) < 0))
        {
            Console.WriteLine("Index of {0} is {1}", maxNumber, index);
        }
        else
        {
            index = Math.Abs(index) - 2;

            if (index >= 0)
            {
                Console.WriteLine(myArr[index]);
            }
            else
            {
                Console.WriteLine("No numbers less than/equal to {0} were found!", maxNumber);
            }
        }
    }
}