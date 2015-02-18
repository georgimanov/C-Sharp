using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        
        int rows = 2 * n + 1;
        int cols = 2 * n + 1;
        char[,] matrix = new char[rows, cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = ' ';
            }
        }

        int left = 0;
        int right = cols - 1;
        for (int row = 0; row < rows; row++)
        {
            matrix[row, left] = '\\';
            if (row == n)
            {
                matrix[row, right] = 'X';
            }
            else
            {
                matrix[row, right] = '/';
            }

            if (row <= n)
            {
                for (int a = 0; a < left; a++)
                {
                    matrix[row, a] = '#';
                    matrix[row, cols - 1 - a] = '#';
                }
            }
            else
            {
                for (int b = 0; b < right; b++)
                {
                    matrix[row, b] = '#';
                    matrix[row, cols - 1 - b] = '#';
                }
            }

            left++;
            right--;
        }

        if (d < n)
        {
            left = 0;
            right = cols - 1;

            int lowerLeft = 0;
            int lowerRight = cols - 1;

            for (int i = 0; i < rows; i++)
            {
                if (left + d + 1 < right - d - 1)
                {
                    matrix[i, left + d + 1] = '\\';
                    matrix[i, right - d - 1] = '/';

                    for (int dot = left + d + 2; dot <= right - d - 2; dot++)
                    {
                        matrix[i, dot] = '.';
                    }
                }
                else
                {
                    break;
                }

                left++;
                right--;
            }

            for (int row = rows - 1; row >= n; row--)
            {
                if (lowerLeft + d + 1 < lowerRight - d - 1)
                {
                    matrix[row, lowerLeft + d + 1] = '/';
                    matrix[row, lowerRight - d - 1] = '\\';

                    for (int dot = lowerLeft + d + 2; dot <= lowerRight - d - 2; dot++)
                    {
                        matrix[row, dot] = '.';
                    }
                }
                else
                {
                    break;
                }

                lowerLeft++;
                lowerRight--;
            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}