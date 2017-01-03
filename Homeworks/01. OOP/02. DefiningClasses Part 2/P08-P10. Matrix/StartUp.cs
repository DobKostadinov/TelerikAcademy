namespace P08_P10.Matrix
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Tasks 8 to 10:");

            int row = 4, col = 4;
            var matrixOne = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixOne[r, c] = r + c;
                }
            }

            Console.WriteLine("Matrix One:");
            Console.WriteLine(matrixOne.ToString());

            var matrixTwo = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrixTwo[r, c] = (r + c) + 2;
                }
            }

            Console.WriteLine("Matrix Two:");
            Console.WriteLine(matrixTwo.ToString());

            Console.WriteLine("Matrix One + Matrix Two:");
            Console.WriteLine(matrixOne + matrixTwo);
            Console.WriteLine("Matrix One - Matrix Two:");
            Console.WriteLine(matrixOne - matrixTwo);
            Console.WriteLine("Matrix One * Matrix Two:");
            Console.WriteLine(matrixOne * matrixTwo);

            if (matrixTwo)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
