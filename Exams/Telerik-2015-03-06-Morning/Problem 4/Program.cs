using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
       
        
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        BigInteger[,] matrix = InitializeMatrix(rows, cols);
        bool[,] visitedCells = InitializeVisitedCells(rows, cols);

        int n = int.Parse(Console.ReadLine()); // number of directions and moves
        var codes = Console.ReadLine().Split(' '); // CODES

        int coef = Math.Max(rows, cols);

        int pawnRow = rows - 1;
        int pawnCol = 0;

        for (int i = 0; i < codes.Length; i++)
        {
            int pathRow = int.Parse(codes[i]) / coef;
            int pathCol = int.Parse(codes[i]) % coef;

            if (pathRow <= pawnRow)
            {
                for (int row = pawnRow; row >= pathRow; row--)
                {
                    visitedCells[row, pawnCol] = true;
                }
            }
            else if (pathRow > pawnRow)
            {
                for (int row = pawnRow; row <= pathRow; row++)
                {
                    visitedCells[row, pawnCol] = true;
                }
            }

            pawnRow = pathRow;

            if (pathCol <= pawnCol)
            {
                for (int col = pawnCol; col >= pathCol; col--)
                {
                    visitedCells[pathRow, col] = true;
                }
            }
            else if (pathCol > pawnCol)
            {
                for (int col = pawnCol; col <= pathCol; col++)
                {
                    visitedCells[pathRow, col] = true;
                }
            }

            pawnCol = pathCol;
        }

        Console.WriteLine(CalculateSum(visitedCells, matrix));
        //PrintMatrix(visitedCells);
        
    }

    private static BigInteger CalculateSum(bool[,] visitedCells, BigInteger[,] matrix)
    {
        BigInteger sum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (visitedCells[row, col])
                {
                    sum += matrix[row, col];
                }
            }
        }

        return sum;
    }

    private static void PrintMatrix(bool[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}".PadRight(5), matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static bool[,] InitializeVisitedCells(int rows, int cols)
    {
        bool[,] visitedCells = new bool[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                visitedCells[row, col] = false;
            }
        }
        return visitedCells;
    }

    private static void PrintMatrix(BigInteger[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}".PadRight(5), matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static BigInteger[,] InitializeMatrix(int rows, int cols)
    {
        BigInteger[,] matrix = new BigInteger[rows, cols];
        for (int row = rows - 1; row >= 0; row--)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row == rows - 1 && col == 0)
                {
                    matrix[row, col] = 1;
                }
                else if (row == rows - 1 && col != 0)
                {
                    matrix[row, col] = matrix[row, col - 1] * 2;
                }
                else
                {
                    matrix[row, col] = matrix[row + 1, col] * 2;
                }
            }
        }
        return matrix;
    }
}