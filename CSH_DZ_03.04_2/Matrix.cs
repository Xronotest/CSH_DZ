using System.Text;

namespace CSH_DZ_03._04_2
{
    internal class Matrix
    {
        private int _row;
        private int _col;
        private int[,] _matrix;

        public int Row { get { return _row; } }
        public int Col { get { return _col; } }

        public Matrix(int row, int col)
        {
            _row = row;
            _col = col;
            _matrix = new int[row, col];

            CreateMatrix();
        }
        private Matrix(int row, int col, bool ymt)
        {
            _row = row;
            _col = col;
            _matrix = new int[row, col];
        }
        private void CreateMatrix()
        {
            for (int i = 0, k = 0; i < _row; i++, k--)
            {
                for (int j = 0; j < _col; j++, k++)
                {
                    Console.Write($"Введите {i + k + 1} значение: ");
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public string PrintMatrix()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    result.Append($" {_matrix[i, j],5} ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }


        public static Matrix operator +(Matrix left, Matrix right)
        {
            Matrix res = new Matrix(left.Row, left.Col, true);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    res._matrix[i, j] = left._matrix[i, j] + right._matrix[i, j];
                }
            }

            return res;
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            Matrix res = new Matrix(left.Row, left.Col, true);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    res._matrix[i, j] = left._matrix[i, j] - right._matrix[i, j];
                }
            }

            return res;
        }

        public static Matrix operator +(Matrix left, int right)
        {
            Matrix res = new Matrix(left.Row, left.Col, true);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    res._matrix[i, j] = left._matrix[i, j] + right;
                }
            }

            return res;
        }

        public static Matrix operator +(int left, Matrix right)
        {
            return right + left;
        }

        public static Matrix operator -(Matrix left, int right)
        {
            Matrix res = new Matrix(left.Row, left.Col, true);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    res._matrix[i, j] = left._matrix[i, j] - right;
                }
            }

            return res;
        }

        public static Matrix operator -(int left, Matrix right)
        {
            Matrix res = new Matrix(right.Row, right.Col, true);

            for (int i = 0; i < right.Row; i++)
            {
                for (int j = 0; j < right.Col; j++)
                {
                    res._matrix[i, j] = left - right._matrix[i, j];
                }
            }

            return res;
        }

        public static Matrix operator *(Matrix left, int right)
        {
            Matrix res = new Matrix(left.Row, left.Col, true);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    res._matrix[i, j] = left._matrix[i, j] * right;
                }
            }

            return res;
        }

        public static Matrix operator *(int left, Matrix right)
        {
            return right * left;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Col != right.Row)
            {
                Console.WriteLine("Умножение невозможно");
                return left;
            }

            Matrix res = new Matrix(left.Row, left.Col, true);

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < right.Col; j++)
                {
                    for (int k = 0; k < left.Col; k++)
                    {
                        res._matrix[i, j] += left._matrix[i, k] * right._matrix[k, j];
                    }
                }
            }

            return res;
        }

        public static bool operator >(Matrix left, Matrix right)
        {
            int resL = 0;
            int resR = 0;

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    resL += left._matrix[i, j] - right._matrix[i, j];
                }
            }
            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    resR += right._matrix[i, j] - left._matrix[i, j];
                }
            }
            if (resL <= resR)
            {
                return false;
            }
            else
            { return true; }
        }

        public static bool operator <(Matrix left, Matrix right)
        {

            int resL = 0;
            int resR = 0;

            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    resL += left._matrix[i, j] - right._matrix[i, j];
                }
            }
            for (int i = 0; i < left.Row; i++)
            {
                for (int j = 0; j < left.Col; j++)
                {
                    resR += right._matrix[i, j] - left._matrix[i, j];
                }
            }
            if (resR <= resL)
            {
                return false;
            }
            else
            { return true; }
        }
    }
}
