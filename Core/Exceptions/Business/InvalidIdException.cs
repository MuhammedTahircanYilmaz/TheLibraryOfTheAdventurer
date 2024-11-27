﻿namespace Core.Exceptions.Business;

public class InvalidIdException : Exception
{
    public InvalidIdException()
    {
    }
    public InvalidIdException(string message) : base(message)
    {
    }
    public InvalidIdException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
