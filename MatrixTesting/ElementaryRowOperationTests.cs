using MatrixCalculator.Matrix;

namespace MatrixTesting {
    public class ElementaryRowOperationTests {
        [Fact]
        public void SwapRows_ValidIndices_RowsSwapped() {
            var matrix = new Matrix(3, 3);

            matrix[0, 0] = 1; matrix[0, 1] = 2; matrix[0, 2] = 3;
            matrix[1, 0] = 4; matrix[1, 1] = 5; matrix[1, 2] = 6;
            matrix[2, 0] = 7; matrix[2, 1] = 8; matrix[2, 2] = 9;

            matrix.SwapRows(0, 1);

            Assert.Equal(4, matrix[0, 0]);
            Assert.Equal(1, matrix[1, 0]);
        }

        [Fact]
        public void MultiplyRow_ValidIndex_RowMultiplied() {
            var matrix = new Matrix(2, 2);
            matrix[0, 0] = 1; matrix[0, 1] = 2;
            matrix[1, 0] = 3; matrix[1, 1] = 4;

            matrix.MultiplyRow(0, 2);

            Assert.Equal(2, matrix[0, 0]);
            Assert.Equal(4, matrix[0, 1]);
        }

        [Fact]
        public void AddRowMultiple_ValidIndices_RowAdded() {
            var matrix = new Matrix(3, 1);
            matrix[0, 0] = 1;
            matrix[1, 0] = 2;
            matrix[2, 0] = 3;

            matrix.AddRowMultiple(0, 1, 2); 

            Assert.Equal(4, matrix[1, 0]);
        }
    }
}
