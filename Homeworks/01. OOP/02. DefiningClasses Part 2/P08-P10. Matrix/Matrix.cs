namespace P08_P10.Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                CheckIfValueIsValid(value);

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                CheckIfValueIsValid(value);

                this.cols = value;
            }
        }

        public T this [int indexRow, int indexCol]
        {
            get
            {
                return this.matrix[indexRow, indexCol];

            }

            set
            {
                if ((indexRow < 0 || indexRow >= this.Rows) ||
                    (indexCol < 0 || indexCol >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[indexRow, indexCol] = value;
            }
        }
        public static Matrix<T> operator +(Matrix<T> firstMtrx, Matrix<T> secondMtrx)
        {
            if (firstMtrx.Cols != secondMtrx.Cols ||
                firstMtrx.Rows != secondMtrx.Rows)
            {
                throw new Exception("You cannot addition matrices with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(firstMtrx.Rows, secondMtrx.Cols);

            for (int i = 0; i < firstMtrx.Rows; i++)
            {
                for (int j = 0; j < secondMtrx.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMtrx[i, j] + secondMtrx[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMtx, Matrix<T> secondMtx)
        {
            if (firstMtx.Cols != secondMtx.Cols ||
                firstMtx.Rows != secondMtx.Rows)
            {
                throw new Exception("You cannot substract matrices with different dimensions");
            }

            Matrix<T> result = new Matrix<T>(firstMtx.Rows, firstMtx.Cols);

            for (int row = 0; row < firstMtx.Rows; row++)
            {
                for (int col = 0; col < firstMtx.Cols; col++)
                {
                    result[row, col] = (dynamic)firstMtx[row, col] - secondMtx[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMtx, Matrix<T> secondMtx)
        {
            if (firstMtx.Cols != secondMtx.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            Matrix<T> result = new Matrix<T>(firstMtx.Rows, secondMtx.Cols);
            T temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)firstMtx[matrixRow, index] * secondMtx[index, matrixCol];
                    }

                    result[matrixRow, matrixCol] = (dynamic)temp;
                }
            }

            return result;
        }

        private static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + "\t");
                }
                result.AppendLine();
            }

            return result.ToString();
        }


        private static void CheckIfValueIsValid(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Size of {value.GetType().Name} cannot be negative");
            }
        }
    }
}
