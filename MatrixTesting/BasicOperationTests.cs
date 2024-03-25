using MatrixCalculator.Matrix;

namespace MatrixTesting {
    public class BasicOperationTests {
        [Fact]
        public void Add_TwoMatrices_ReturnsCorrectSum() {
            // Arrange
            var matrixA = new Matrix(2, 2);
            matrixA[0, 0] = 1;
            matrixA[0, 1] = 2;
            matrixA[1, 0] = 3;
            matrixA[1, 1] = 4;

            var matrixB = new Matrix(2, 2);
            matrixB[0, 0] = 5;
            matrixB[0, 1] = 6;
            matrixB[1, 0] = 7;
            matrixB[1, 1] = 8;

            // Act
            var result = matrixA + matrixB;

            // Assert
            Assert.Equal(6, result[0, 0]);
            Assert.Equal(8, result[0, 1]);
            Assert.Equal(10, result[1, 0]);
            Assert.Equal(12, result[1, 1]);
        }

        [Fact]
        public void Subtract_TwoMatrices_ReturnsCorrectDifference() {
            // Arrange
            var matrixA = new Matrix(2, 2);
            matrixA[0, 0] = 1;
            matrixA[0, 1] = 2;
            matrixA[1, 0] = 3;
            matrixA[1, 1] = 4;

            var matrixB = new Matrix(2, 2);
            matrixB[0, 0] = 5;
            matrixB[0, 1] = 6;
            matrixB[1, 0] = 7;
            matrixB[1, 1] = 8;

            // Act
            var result = matrixA - matrixB;

            // Assert
            Assert.Equal(-4, result[0, 0]);
            Assert.Equal(-4, result[0, 1]);
            Assert.Equal(-4, result[1, 0]);
            Assert.Equal(-4, result[1, 1]);
        }

        [Fact]
        public void Multiply_TwoMatrices_ReturnsCorrectProduct() {
            // Arrange
            var matrixA = new Matrix(2, 3);
            matrixA[0, 0] = 1;
            matrixA[0, 1] = 2;
            matrixA[0, 2] = 3;
            matrixA[1, 0] = 4;
            matrixA[1, 1] = 5;
            matrixA[1, 2] = 6;

            var matrixB = new Matrix(3, 2);
            matrixB[0, 0] = 7;
            matrixB[0, 1] = 8;
            matrixB[1, 0] = 9;
            matrixB[1, 1] = 10;
            matrixB[2, 0] = 11;
            matrixB[2, 1] = 12;

            // Expected result
            // | 58  64 |
            // | 139 154 |

            // Act
            var result = matrixA * matrixB;

            // Assert
            Assert.Equal(58, result[0, 0]);
            Assert.Equal(64, result[0, 1]);
            Assert.Equal(139, result[1, 0]);
            Assert.Equal(154, result[1, 1]);
        }

        [Fact]
        public void DotProduct_TwoVectors_ReturnsCorrectResult() {
            // Arrange
            var vectorA = new Matrix(1, 3);
            vectorA[0, 0] = 1;
            vectorA[0, 1] = 3;
            vectorA[0, 2] = -5;

            var vectorB = new Matrix(1, 3);
            vectorB[0, 0] = 4;
            vectorB[0, 1] = -2;
            vectorB[0, 2] = -1;

            // Act
            var result = vectorA.DotProduct(vectorB);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void CrossProduct_TwoVectors_ReturnsCorrectResult() {
            // Arrange
            var vectorA = new Matrix(3, 1);
            vectorA[0, 0] = 1;
            vectorA[1, 0] = 2;
            vectorA[2, 0] = 3;

            var vectorB = new Matrix(3, 1);
            vectorB[0, 0] = 4;
            vectorB[1, 0] = 5;
            vectorB[2, 0] = 6;

            // Act
            var result = vectorA.CrossProduct(vectorB);

            // Assert
            Assert.Equal(-3, result[0, 0]);
            Assert.Equal(6, result[1, 0]);
            Assert.Equal(-3, result[2, 0]);
        }

        [Fact]
        public void ScalarTriple_ThreeVectors_ReturnsCorrectResult() {
            // Arrange
            var vectorA = new Matrix(3, 1);
            vectorA[0, 0] = 1;
            vectorA[1, 0] = 2;
            vectorA[2, 0] = 3;

            var vectorB = new Matrix(3, 1);
            vectorB[0, 0] = 4;
            vectorB[1, 0] = 5;
            vectorB[2, 0] = 6;

            var vectorC = new Matrix(3, 1);
            vectorC[0, 0] = 7;
            vectorC[1, 0] = 8;
            vectorC[2, 0] = 9;

            // Act
            double result = vectorA.ScalarTriple(vectorB, vectorC);

            // Assert
            Assert.Equal(0, result);
        }

    }
}