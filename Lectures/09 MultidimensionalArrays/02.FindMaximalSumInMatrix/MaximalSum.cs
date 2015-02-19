using System;
class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter M: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int maximalSum = 0;
        int mRow = 0;
        int mCol = 0;
        for (int col = 0; col <= cols - 3; col++)
        {
            for (int row = 0; row <= rows - 3; row++)
            {
                int currentSum = 0;
                currentSum = 
                    matrix[row, col] +
                    matrix[row, col + 1] +
                    matrix[row, col + 2] +
                    matrix[row + 1, col] +
                    matrix[row + 1, col + 1] +
                    matrix[row + 1, col + 2] +
                    matrix[row + 2, col] +
                    matrix[row + 2, col + 1] +
                    matrix[row + 2, col + 2];

                if (currentSum > maximalSum)
                {
                    maximalSum = currentSum;
                    mRow = row;
                    mCol = col;
                }
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0}".PadRight(4), matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Maximal sum :{0}", maximalSum);

        for (int row = mRow; row < mRow + 3; row++)
        {
            for (int col = mCol; col < mCol + 3; col++)
            {
                Console.Write("{0}".PadRight(4), matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}