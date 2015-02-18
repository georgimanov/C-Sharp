/*
Problem 19.	** Spiral Matrix
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. Examples:
n	matrix		
2	1 2
    4 3
 * 
3	1 2 3
    8 9 4
    7 6 5
 * 
 4	1  2  3  4
    12 13 14 5
    11 16 15 6
    10 9  8  7
*/

using System;

class PrintSpiral
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int currentCount = 1;
        int size = n;
        int row = 0;
        int col = 0;

        while (size > 0)
        {
            for (int i = col; i <= col + size - 1; i++)
            {
                matrix[row, i] = currentCount++;
            }

            for (int j = row + 1; j <= row + size - 1; j++)
            {
                matrix[j, col + size - 1] = currentCount++;
            }

            for (int i = col + size - 2; i >= col; i--)
            {
                matrix[row + size - 1, i] = currentCount++;
            }

            for (int i = row + size - 2; i >= row + 1; i--)
            {
                matrix[i, col] = currentCount++;
            }

            row = row + 1;
            col = col + 1;
            size = size - 2;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}