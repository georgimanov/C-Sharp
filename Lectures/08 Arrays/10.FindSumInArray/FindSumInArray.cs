using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string [example: 4, 3, 1, 4, 2, 5, 8]");
            string input = Console.ReadLine();

            Console.WriteLine("Enter S: ");
            int s = int.Parse(Console.ReadLine());

            // Comment left for testing purposes only
            // string input = "4, 3, 1, 4, 2, 5, 8";
            // int s = 11;

            char[] delimiter = { ',' };
            string[] inputArray = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            int[] myArr = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                myArr[i] = int.Parse(inputArray[i]);
            }

            Console.WriteLine(String.Join(", ", myArr));

            List<int> currentSequence = new List<int>();
            for (int i = 0; i < myArr.Length; i++)
            {
                int currentSum = myArr[i];
                currentSequence.Add(myArr[i]);
                for (int j = i + 1; j < myArr.Length;  j++)
                {
                    currentSum += myArr[j];
                    currentSequence.Add(myArr[j]);
                    if (currentSum == s)
                    {
                        Console.WriteLine(String.Join(", ", currentSequence));
                    }
                    else if (currentSum > s)
                    {
                        break;
                    }
                }
                currentSequence.Clear();
            }
        }
    }
}
