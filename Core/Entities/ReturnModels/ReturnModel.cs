namespace Core.Entities.ReturnModels;

public class ReturnModel<TData>
{
    public TData? Data { get; set; }
    public string? Message { get; set; }
    public bool Success { get; set; }
    public int Status { get; set; }

    public static ReturnModel<TData> ReturnModelOfException(Exception exception, int status)
    {
        return new ReturnModel<TData>
        {
            Data = default,
            Message = exception.Message,
            Success = false,
            Status = status
        };
    }

    public static ReturnModel<TData> ReturnModelOfSuccess(TData data, string message, int status)
    {
        return new ReturnModel<TData>
        {
            Data = data,
            Message = message,
            Status = status,
            Success = true
        };
    }
}
