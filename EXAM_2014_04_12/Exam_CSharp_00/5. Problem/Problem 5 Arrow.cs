using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n * 2 - 1;
            int cols = n * 2 - 1;
            char[,] matrix = new char[rows, cols];
            
            InitializeMatrix(matrix);

            int leftPivot = n /2;
            int rightPivot = cols - n / 2  - 1;

            //first row
            for (int i = leftPivot; i <= rightPivot; i++)
            {
                matrix[0, i] = '#';
            }

            //upper part
            for (int i = 1; i < n; i++)
            {
                matrix[i, leftPivot] = '#';
                matrix[i, rightPivot] = '#';
            }
           
            // middle part

            leftPivot = 0;
            rightPivot = cols - 1;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                matrix[n - 1, leftPivot + i] = '#';
                matrix[n - 1, rightPivot - i] = '#';

            }
            leftPivot = 1;
            rightPivot = cols - 2;

            //lower part

            for (int row = n; row < rows - 1; row++)
            {
                matrix[row, leftPivot] = '#';
                matrix[row, rightPivot] = '#';
                leftPivot++;
                rightPivot--;
            }


            //bottom row
            matrix[rows - 1, cols / 2 ] = '#';
 
            PrintMatrix(matrix);


        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void InitializeMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = '.';
                }
            }
        }
    }
}
