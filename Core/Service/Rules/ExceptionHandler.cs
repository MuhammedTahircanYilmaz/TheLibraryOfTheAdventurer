using Core.Entities.ReturnModels;
using Core.Exceptions.Business;
using Core.Exceptions.NotFound;

namespace Core.Service.Rules;

public class ExceptionHandler<T>
{
    public static ReturnModel<T> HandleExceptions(Exception exception)
    {
        if (exception.GetType() == typeof(NotFoundException))
        {
            return ReturnModel<T>.ReturnModelOfException(exception,404);
        }
        else if(exception.GetType() == typeof(BusinessException))
        {
            return ReturnModel<T>.ReturnModelOfException(exception, 400);
        }
        return ReturnModel<T>.ReturnModelOfException(exception, 500);
    }
}
