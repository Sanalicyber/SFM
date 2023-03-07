namespace SFM_API.Logger.Models.Exception;

public interface ILogException : ILogModel
{
    public string Message { get; set; }
    public LogExceptionType Type { get; set; }
}