namespace Maxtrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Common;

    public class Matrix<T>
    {
        private const int InitialSizeRows = 16;
        private const int InitialSizeCols = 16;

        private T[,] matrix;

        public Matrix()
            : this(InitialSizeRows, InitialSizeCols)
        {
            this.matrix = new T[InitialSizeRows, InitialSizeCols];
        }

        public Matrix(int initialSizeRows, int initialSizeCols)
        {
            if (initialSizeRows < 2 || initialSizeCols < 2)
            {
                throw new IndexOutOfRangeException("Initial size (rows/cols) must be bigger than 2");
            }

            this.matrix = new T[initialSizeRows, initialSizeCols];
        }

        public T GetElement(int row, int col)
        {
            if ( ! ((this.matrix.GetLength(0) > row && row >= 0) &&
                 (this.matrix.GetLength(1) > col && col >= 0)))
            {
                throw new IndexOutOfRangeException("rows/cols must be inside matrix");
            }

            return this.matrix[row, col];
        }

        public void SetElement(int row, int col, T value)
        {
            if (!((this.matrix.GetLength(0) > row && row >= 0) &&
                 (this.matrix.GetLength(1) > col && col >= 0)))
            {
                throw new IndexOutOfRangeException("rows/cols must be inside matrix");
            }

            this.matrix[row, col] = value;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    Console.Write("{0}".PadRight(8), this.matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
