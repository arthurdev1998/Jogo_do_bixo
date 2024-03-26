namespace JogodoBixo.Common.Messages;

public class ServiceResult<T>
{
    public T? Data { get; set; }
    public bool HasError { get; set; } = false;
    public List<string>? ErrorMessage { get; set; }

    public ServiceResult(){}

    public ServiceResult(T data)
    {
        Data = data;
    }
}