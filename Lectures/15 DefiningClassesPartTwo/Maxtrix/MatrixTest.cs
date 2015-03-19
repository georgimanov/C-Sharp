namespace Maxtrix
{
    using System;
    
    internal class MatrixTest
    {
        private static void Main(string[] args)
        {
            var matrixOne = new Matrix<int>(2, 2);
            matrixOne[0, 0] = 1;
            matrixOne[0, 1] = 2;
            matrixOne[1, 0] = 3;
            matrixOne[1, 1] = 4;

            var matrixTwo = new Matrix<int>(2, 2);
            matrixTwo[0, 0] = 0;
            matrixTwo[0, 1] = 6;
            matrixTwo[1, 0] = 7;
            matrixTwo[1, 1] = 8;

            Console.WriteLine(new string('-', 10));

            Console.WriteLine("Matrix (a)");
            Console.WriteLine(new string('-', 10));

            matrixOne.PrintMatrix();
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Matrix (b)");
            Console.WriteLine(new string('-', 10));

            matrixTwo.PrintMatrix();
            Console.WriteLine(new string('=', 10));
            Console.WriteLine("Plus (a + b)");
            Console.WriteLine("Equals (=)");
            var matrixPlus = matrixOne + matrixTwo;
            matrixPlus.PrintMatrix();

            Console.WriteLine(new string('=', 10));
            Console.WriteLine("Minus (a - b)");
            Console.WriteLine("Equals (=)");
            var matrixMinus = matrixOne - matrixTwo;
            matrixMinus.PrintMatrix();

            var mOne = new Matrix<int>(2, 3);
            mOne[0, 0] = 1;
            mOne[0, 1] = 2;
            mOne[0, 2] = 3;
            mOne[1, 0] = 4;
            mOne[1, 1] = 5;
            mOne[1, 2] = 6;

            var mTwo = new Matrix<int>(3, 2);
            mTwo[0, 0] = 7;
            mTwo[0, 1] = 8;
            mTwo[1, 0] = 9;
            mTwo[1, 1] = 10;
            mTwo[2, 0] = 11;
            mTwo[2, 1] = 12;

            Console.WriteLine(new string('-', 10));

            Console.WriteLine("Matrix (A)");
            mOne.PrintMatrix();
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Matrix (B)");
            mTwo.PrintMatrix();
            Console.WriteLine(new string('-', 10));

            Console.WriteLine(new string('=', 10));
            Console.WriteLine("Multiply (A * B)");
            Console.WriteLine("Equals (=)");
            var matrixMultiply = mOne*mTwo;
            matrixMultiply.PrintMatrix();

            Console.WriteLine(new string('=', 10));

            matrixOne.PrintMatrix();

            if (matrixOne)
            {
                Console.WriteLine("Matrix has ZERO value");
            }
            else
            {
                Console.WriteLine("Does NOT have ZERO value");
            }

            Console.WriteLine(new string('=', 10));

            matrixTwo.PrintMatrix();
            if (matrixTwo)
            {
                Console.WriteLine("Matrix has ZERO value");
            }
            else
            {
                Console.WriteLine("Does NOT have ZERO value");
            }

            Console.WriteLine(new string('=', 10));
        }
    }
}