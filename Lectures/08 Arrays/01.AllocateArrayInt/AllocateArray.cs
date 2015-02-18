using System;
static class Program
{
    static void Main()
    {
        int[] myArr = new int[20];
        for (int i = 0; i < myArr.Length; i++)
        {
            myArr[i] = i * 5;
        }

        Console.WriteLine(String.Join(" ", myArr));
    }
}