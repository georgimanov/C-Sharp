using System;
class Program
{
    static void Main(string[] args)
    {
        char[] myCharArr = new char[26];
        for (int i = 0; i < myCharArr.Length; i++)
        {
            myCharArr[i] = (char)((int)'A' + i);
        }

        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        input = input.ToUpper();
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine("Symbol ['{0}'] -> Index in array [{1}]", input[i], Array.IndexOf(myCharArr, input[i]));
        }
    }
}