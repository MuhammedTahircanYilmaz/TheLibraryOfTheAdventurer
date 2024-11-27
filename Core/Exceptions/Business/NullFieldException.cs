namespace Core.Exceptions.Business
{
    public class NullFieldException : Exception
    {
        public NullFieldException()
        {
        }

        public NullFieldException(string message) : base(message)
        {
        }

        public NullFieldException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
