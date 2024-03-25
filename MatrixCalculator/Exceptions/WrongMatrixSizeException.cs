namespace MatrixTesting.Exceptions {
    public class WrongMatrixSizeException : Exception {
        public WrongMatrixSizeException() : base() { }

        public WrongMatrixSizeException(string message) : base(message) { }

        public WrongMatrixSizeException(string message, Exception inner) : base(message, inner) { }
    }
}
