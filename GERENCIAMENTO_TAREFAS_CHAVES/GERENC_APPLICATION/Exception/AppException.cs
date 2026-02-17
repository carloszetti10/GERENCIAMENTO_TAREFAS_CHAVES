namespace GERENC_APPLICATION.Exceptions
{
    public class AppException : Exception
    {

        public AppException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
        public AppException(string? message) : base(message)
        {
        }
    }
}
