using System;
class FindSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter M: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
         

        int maximalRowSequence = 1;
        string elementRow = String.Empty;
        for (int row = 0; row < rows; row++)
        {
            int currentRowSequence = 1;
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentRowSequence++;
                }
                if (currentRowSequence >= maximalRowSequence)
                {
                    maximalRowSequence = currentRowSequence;
                    elementRow = matrix[row, col];
                }
            }
        }

        int maximalColSequence = 1;
        string elementCol = String.Empty;
        for (int col = 0; col < cols; col++)
        {
            int currentColSequence = 1;
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentColSequence++;
                }
                if (currentColSequence >= maximalColSequence)
                {
                    maximalColSequence = currentColSequence;
                    elementCol = matrix[row, col];
                }
            }
        }

        int maximalDiagonalSequence = 1;
        string elementDiagonal = String.Empty;
        int diagonal = Math.Max(rows, cols);
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                int currentDiagonalSequence = 1;
                for (int i = 1; i < diagonal; i++)
                {
                    if (row + i == rows || col + i == cols)
                    {
                        break;
                    }
                    if (matrix[row, col] == matrix[row + i, col + i])
                    {
                        currentDiagonalSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentDiagonalSequence >= maximalDiagonalSequence)
                {
                    maximalDiagonalSequence = currentDiagonalSequence;
                    elementDiagonal = matrix[row, col];
                }
            }
        }

        if (maximalRowSequence > maximalDiagonalSequence && maximalRowSequence > maximalColSequence)
        {
            Console.WriteLine("Max row sequence {0}", maximalRowSequence);
            PrintResult(elementRow, maximalRowSequence);
        }

        if (maximalColSequence > maximalDiagonalSequence && maximalColSequence > maximalRowSequence)
        {
            Console.WriteLine("Max col sequence {0}", maximalColSequence);
            PrintResult(elementCol, maximalColSequence);

        }

        if (maximalDiagonalSequence > maximalColSequence && maximalDiagonalSequence > maximalRowSequence)
        {
            Console.WriteLine("Max diagonal sequence {0}", maximalDiagonalSequence);
            PrintResult(elementDiagonal, maximalDiagonalSequence);
        }
    }

    private static void PrintResult(string elementRow, int maximalRowSequence)
    {
        for (int i = 0; i < maximalRowSequence; i++)
        {
            Console.Write(elementRow);
            if (i < maximalRowSequence - 1)
            {
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}