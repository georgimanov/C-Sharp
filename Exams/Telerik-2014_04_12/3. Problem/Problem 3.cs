using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool printResult = false;

            char[] arr = { 'a', 'b', 'c', 'd', 'e' };

            long weight = 0;

            string sequence = "";

            StringBuilder uniqueSequence = new StringBuilder();

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = 0; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        for (int d = 0; d < arr.Length; d++)
                        {
                            for (int e = 0; e < arr.Length; e++)
                            {
                                Object[] objs = new Object[] {arr[a], arr[b], arr[c], arr[d], arr[e]};

                                sequence = String.Concat(objs);

                                string answer = new string(sequence.Distinct().ToArray());

                                char[] arrayOfChars = new char[answer.Length];

                                for (int i = 0; i < answer.Length; i++)
                                {
                                    arrayOfChars[i] = answer[i];
                                }
                                
                                for (int i = 0; i < answer.Length; i++)
                                {
                                    weight += calculateLetter(arrayOfChars, i) * (i + 1);
                                }

                                if (weight >= start && weight <= end)
                                {
                                    Console.Write("{0} ", sequence, weight);
                                    printResult = true;
                                }
                                
                                weight = 0;
                            }
                        }
                    }
                }
            }
            if (!printResult)
            {
                Console.WriteLine("No");
            }
        }
	

        private static int calculateLetter(char[] arr, int position)
        {
            int weightLetter = 0;

            switch (arr[position])
            {
                case 'a': weightLetter = 5; break;
                case 'b': weightLetter = -12; break;
                case 'c': weightLetter = 47; break;
                case 'd': weightLetter = 7; break;
                case 'e': weightLetter = -32; break;

                default:
                    break;
            }
            return weightLetter;
        }


    }
}
