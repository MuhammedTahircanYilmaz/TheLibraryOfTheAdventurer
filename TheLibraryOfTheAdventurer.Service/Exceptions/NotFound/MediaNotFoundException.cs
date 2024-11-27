namespace TheLibraryOfTheAdventurer.Service.Exceptions.NotFound;

public class MediaNotFoundException : Exception
{
    public MediaNotFoundException()
    {
    }
    public MediaNotFoundException(string message) : base(message)
    {
    }
    public MediaNotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
