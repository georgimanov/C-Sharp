using System;
class CompareArrays
{
    static void Main(string[] args)
    {
        bool arraysAraEqaul = true;

        Console.WriteLine("Enter first array [example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
        string input = Console.ReadLine();
        char[] delimiter = { ',' };
        string[] firstArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Enter second array [example: 2, 1, 1, 2, 3, 3, 2, 2, 2, 1]");
        input = Console.ReadLine();
        string[] secondArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        if (firstArray.Length != secondArray.Length)
        {
            arraysAraEqaul = false;
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    arraysAraEqaul = false;
                    break;
                }
            }
        }

        if (arraysAraEqaul)
        {
            Console.WriteLine("The two arrays are eqaul");
        }
        else
        {
            Console.WriteLine("The two arrays are NOT equal");
        }

        if (arraysAraEqaul && firstArray.Length == 0)
        {
            Console.WriteLine("and both arrays are empty!");
        }
    }
}