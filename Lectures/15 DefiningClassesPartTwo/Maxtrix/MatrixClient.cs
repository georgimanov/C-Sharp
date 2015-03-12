using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxtrix
{
    class MatrixClient
    {
        static void Main(string[] args)
        {
            var rows = 4;
            var cols = 4;
            var matrix = new Matrix<int>(rows, cols);

            var counter = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix.SetElement(row, col, counter++);
                }
            }

            var getRow = 1;
            var getCol = 1;
            matrix.PrintMatrix();
            Console.WriteLine("matrix[{0}, {1}] = {2}", getRow, getCol, matrix.GetElement(1, 1));
        }
    }
}
