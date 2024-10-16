namespace Core.Entities.ReturnModels;

public class ReturnModel<TData>
{
    public ReturnModel()
    {

    }

    public ReturnModel(TData data, string message, bool success, int status)
    {
        Data = data;
        Message = message;
        Success = success;
        Status = status;
    }
    public TData? Data { get; set; }
    public string Message { get; set; }
    public bool Success { get; set; }
    public int Status { get; set; }
}
