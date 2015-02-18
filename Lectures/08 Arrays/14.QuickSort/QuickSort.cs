using System;
class QuickSort
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter string [example: 2, 3, -6, -1, 6, 4, -8, 8]");
        string input = Console.ReadLine();

        char[] delimiter = { ',' };
        string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            numbers[i] = int.Parse(inputArray[i]);
        }
        
        //int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

        Console.WriteLine("QuickSort By Recursive Method");

        QuickSortRecursive(numbers, 0, numbers.Length - 1);
 
        Console.WriteLine(String.Join(", ", numbers));
    }

    private static void QuickSortRecursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            if (pivot > 1)
            {
                QuickSortRecursive(arr, left, pivot - 1);
            }

            if (pivot + 1 < right)
            {
                QuickSortRecursive(arr, pivot + 1, right);
            }
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];

        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}