using MatrixTesting.Exceptions;

namespace MatrixCalculator.Matrix {
    public class Matrix(int rows, int columns) {
        private readonly double[,] data = new double[rows, columns];
        public int Rows { get; } = rows;
        public int Columns { get; } = columns;

        public double this[int i, int j] {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        public static Matrix operator +(Matrix a, Matrix b) {
            if (a.Rows != b.Rows || a.Columns != b.Columns) {
                throw new WrongMatrixSizeException("Matrix dimensions must match for addition.");
            }

            var result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++) {
                for (int j = 0; j < a.Columns; j++) {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix a, Matrix b) {
            if (a.Rows != b.Rows || a.Columns != b.Columns) {
                throw new WrongMatrixSizeException("Matrix dimensions must match for subtraction.");
            }

            var result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++) {
                for (int j = 0; j < a.Columns; j++) {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b) {
            if (a.Columns != b.Rows) {
                throw new WrongMatrixSizeException("Matrix dimensions are not compatible for multiplication.");
            }

            var result = new Matrix(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; i++) {
                for (int j = 0; j < b.Columns; j++) {
                    for (int k = 0; k < a.Columns; k++) {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        public override string ToString() {
            var stringBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < Rows; i++) {
                stringBuilder.Append("| ");
                for (int j = 0; j < Columns; j++) {
                    stringBuilder.Append($"{data[i, j],5:0.##} ");
                }
                stringBuilder.AppendLine("|");
            }
            return stringBuilder.ToString();
        }
    }
}
