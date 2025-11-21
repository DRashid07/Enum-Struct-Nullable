namespace Custom_Exception
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException() { }
        public NotAvailableException(string message) : base(message) { }

    }
    public class NotFoundException : Exception
    {
        public NotFoundException() { }
        public NotFoundException(string message) : base(message) { }

    }
}
