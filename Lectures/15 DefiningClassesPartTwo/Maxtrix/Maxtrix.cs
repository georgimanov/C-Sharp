using System.CodeDom;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace Maxtrix
{
    using System;

    public class Matrix<T> 
        where T : IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
        }

        public T this[int row, int col]
        {
            get
            {
                if (((row < 0) || row >= this.Rows) ||
                ((col < 0) || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if (((row < 0) || row >= this.Rows) ||
                ((col < 0) || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.Rows;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix should have at least one row");
                }
         
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.Cols;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix should have at least one column");
                }

                this.cols = value;
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    Console.Write("{0}".PadRight(8), this.matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {

            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentOutOfRangeException("Matrices should be of the same size");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentOutOfRangeException("Matrices should be of the same size");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            // TODO:

            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentOutOfRangeException("Matrices should be of the same size");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, b.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }

            return result;
        }
    }
}
