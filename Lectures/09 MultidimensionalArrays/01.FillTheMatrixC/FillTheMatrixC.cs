using System;
class FillTheMatrixC
{
    static void Main(string[] args)
    {
        int rows = 4;
        int cols = 4;
        int[,] matrix = new int[rows, cols];

        int counter = 1;
        for (int col = 0; col < cols; col++)
        {
            for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
            {
                matrix[row, col] = row + col;
                counter++;
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}