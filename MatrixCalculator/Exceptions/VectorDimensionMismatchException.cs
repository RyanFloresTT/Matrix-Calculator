namespace MatrixCalculator.Exceptions {
    public class VectorDimensionMismatchException : Exception {
        public VectorDimensionMismatchException() : base() { }

        public VectorDimensionMismatchException(string message) : base(message) { }

        public VectorDimensionMismatchException(string message, Exception inner) : base(message, inner) { }
    }
}
