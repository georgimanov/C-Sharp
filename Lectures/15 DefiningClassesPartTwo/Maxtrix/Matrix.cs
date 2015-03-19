namespace Maxtrix
{
    using System;

    public class Matrix<T>
        where T : IComparable
    {
        private readonly T[,] matrix;
        private int cols;
        private int rows;

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                if (((row < 0) || row >= Rows) ||
                    ((col < 0) || col >= Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return matrix[row, col];
            }
            set
            {
                if (((row < 0) || row >= Rows) ||
                    ((col < 0) || col >= Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                if (value.Equals(null))
                {
                    throw new ArgumentNullException();
                }

                matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get { return rows; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix should have at least one row");
                }

                rows = value;
            }
        }

        public int Cols
        {
            get { return cols; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix should have at least one column");
                }

                cols = value;
            }
        }

        public void PrintMatrix()
        {
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Cols; j++)
                {
                    Console.Write("{0}".PadRight(8), matrix[i, j]);
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

            var result = new Matrix<T>(a.Rows, a.Cols);

            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic) a[row, col] + b[row, col];
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

            var result = new Matrix<T>(a.Rows, a.Cols);

            for (var row = 0; row < a.Rows; row++)
            {
                for (var col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic) a[row, col] - b[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Cols || a.Cols != b.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            var result = new Matrix<T>(a.Rows, b.Cols);
            int temp;

            for (var row = 0; row < result.Rows; row++)
            {
                for (var col = 0; col < result.Cols; col++)
                {
                    temp = 0;
                    for (var index = 0; index < result.Rows; index++)
                    {
                        temp += (dynamic) a[row, index]*b[index, col];
                    }
                    result[row, col] = (dynamic) temp;
                }
            }

            return result;
        }

        public static bool OverrideBool(Matrix<T> matrix)
        {
            for (var row = 0; row < matrix.Rows; row++)
            {
                for (var col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic) 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }
    }
}