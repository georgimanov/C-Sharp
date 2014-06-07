/*
Problem 3.	Primes in Given Range
Write a method that calculates all prime numbers in given range and returns them as list of integers:
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
 Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
Examples:
Start number * End number *	Output
0              10	        2, 3, 5, 7
5              11	        5, 7, 11
*/
using System;
using System.Collections.Generic;
    class PrimesInRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start number");
            int starNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number");
            int endNum = int.Parse(Console.ReadLine());
            PrimeNumbersInList(starNum, endNum);
        }
        public static List<int> PrimeNumbersInList(int startNum, int endNum)
        {
            List<int> myList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if ( isPrime(i))
                {
                    myList.Add(i);
                }
            }
            
            foreach (var item in myList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            return myList;
        }
        public static bool isPrime(long number)
        {
            double boundary = Math.Sqrt(number);

            if (number == 0) return false; 
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }