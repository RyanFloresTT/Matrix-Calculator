using MatrixCalculator.Exceptions;
using MatrixTesting.Exceptions;

namespace MatrixCalculator.Matrix {
    public static class MatrixOperations {
        public static double DotProduct(this Matrix a, Matrix b) {
            if ((a.Rows != 1 && a.Columns != 1) || (b.Rows != 1 && b.Columns != 1) || (a.Rows * a.Columns != b.Rows * b.Columns))
                throw new VectorDimensionMismatchException("Both matrices must be vectors of the same dimension.");

            double result = 0;
            for (int i = 0; i < a.Rows; i++) {
                for (int j = 0; j < a.Columns; j++) {
                    result += a[i, j] * b[i, j];
                }
            }
            return result;
        }
        
        public static Matrix CrossProduct(this Matrix a, Matrix b) {
            if ((a.Rows == 3 && a.Columns == 1) && (b.Rows == 3 && b.Columns == 1)) {
                Matrix result = new Matrix(3, 1);
                result[0, 0] = a[1, 0] * b[2, 0] - a[2, 0] * b[1, 0];
                result[1, 0] = a[2, 0] * b[0, 0] - a[0, 0] * b[2, 0];
                result[2, 0] = a[0, 0] * b[1, 0] - a[1, 0] * b[0, 0];
                return result;
            } else {
                throw new WrongMatrixSizeException("Cross product is only defined for 3D vectors.");
            }
        }

        public static double ScalarTriple(this Matrix a, Matrix b, Matrix c) {
            return a.DotProduct(b.CrossProduct(c));
        }

        public static void SwapRows(this Matrix matrix, int row1, int row2) {
            if (row1 < 0 || row2 < 0 || row1 >= matrix.Rows || row2 >= matrix.Rows) {
                throw new IndexOutOfRangeException($"Row Values out of range of Matrix. Row1: {row1}. Row2 : {row2}. Matrix Row Count : {matrix.Rows}.");
            }

            var tmp = matrix[0, 0]; //init var outside for scope, but needed to init to a value to get the type
            for (int i = 0; i < matrix.Columns; i++) {
                tmp = matrix[row2, i];
                matrix[row2, i] = matrix[row1, i];
                matrix[row1, i] = tmp;
            }
            Console.WriteLine($"Swapping row {row1} with row {row2}");
        }

        public static void MultiplyRow(this Matrix matrix, int row, double scalar) {
            if (row < 0 || row >= matrix.Rows) {
                throw new IndexOutOfRangeException($"Row value out of range. Row: {row}. Matrix Row Count: {matrix.Rows}.");
            }

            for (int i = 0; i < matrix.Columns; i++) {
                matrix[row, i] *= scalar;
            }
            Console.WriteLine($"Multiplying row {row} by {scalar}");
        }

        public static void AddRowMultiple(this Matrix matrix, int sourceRow, int targetRow, double scalar) {
            if (sourceRow < 0 || targetRow < 0 || sourceRow >= matrix.Rows || targetRow >= matrix.Rows) {
                throw new IndexOutOfRangeException($"Row values out of range. SourceRow: {sourceRow}, TargetRow: {targetRow}, Matrix Row Count: {matrix.Rows}.");
            }

            for (int i = 0; i < matrix.Columns; i++) {
                matrix[targetRow, i] += matrix[sourceRow, i] * scalar;
            }
            Console.WriteLine($"Adding {scalar} times row {sourceRow} to row {targetRow}");
        }
    }
}
