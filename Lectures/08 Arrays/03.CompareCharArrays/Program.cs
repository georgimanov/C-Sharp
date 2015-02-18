using System;
class CompareArrays
{
    static void Main(string[] args)
    {
        bool arraysAraEqaul = true;

        Console.WriteLine("Enter first array [example: Hello]");
        string input = Console.ReadLine();
        char[] firstArray = input.ToCharArray();

        Console.WriteLine("Enter second array [example: World]");
        input = Console.ReadLine();
        char[] secondArray = input.ToCharArray();

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