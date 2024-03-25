using MatrixCalculator.Exceptions;
using MatrixCalculator.Matrix;
using MatrixTesting.Exceptions;

namespace MatrixTesting {
    public class ExceptionTests {
        [Fact]
        public void CrossProduct_WrongDimensions_ThrowsException() {
            // Arrange
            var vectorA = new Matrix(2, 1);
            vectorA[0, 0] = 1;
            vectorA[1, 0] = 2;

            var vectorB = new Matrix(3, 1);
            vectorB[0, 0] = 3;
            vectorB[1, 0] = 4;
            vectorB[2, 0] = 5;

            // Act & Assert
            Assert.Throws<WrongMatrixSizeException>(() => vectorA.CrossProduct(vectorB));
        }

        [Fact]
        public void DotProduct_MismatchDimensions_ThrowsException() { 
            var matrixA = new Matrix(2, 1);
            var matrixB = new Matrix(3, 1);

            Assert.Throws<VectorDimensionMismatchException>(() => matrixA.DotProduct(matrixB));
        }

        [Fact]
        public void SwapRows_InvalidIndices_ThrowsException() {
            var matrix = new Matrix(2, 2);

            Assert.Throws<IndexOutOfRangeException>(() => matrix.SwapRows(-1, 2));
        }
        [Fact]
        public void MultiplyRow_InvalidIndex_ThrowsException() {
            var matrix = new Matrix(2, 2);

            Assert.Throws<IndexOutOfRangeException>(() => matrix.MultiplyRow(2, 3));
        }
        [Fact]
        public void AddRowMultiple_InvalidIndices_ThrowsException() {
            var matrix = new Matrix(2, 2);

            Assert.Throws<IndexOutOfRangeException>(() => matrix.AddRowMultiple(1, 2, 3));
        }
    }
}
