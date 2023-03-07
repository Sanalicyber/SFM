namespace SFM_API.Logger;

public static class SLogger
{
    private const string LogFolder = "C://SFM/Logs/";
    private const string LogFile = "SFM.log";
    
    private static StreamWriter _logWriter;
    
    public static void Initialize()
    {
        if (!Directory.Exists(LogFolder))
        {
            Directory.CreateDirectory(LogFolder);
        }
        
        _logWriter = new StreamWriter(LogFolder + LogFile, true);
    }
    
    public static void Log(string message)
    {
        _logWriter.WriteLine($"[{DateTime.Now}] {message}");
        _logWriter.Flush();
    }
    
    public static void LogException(Exception exception)
    {
        _logWriter.WriteLine($"[{DateTime.Now}] {exception.Message}");
        _logWriter.WriteLine($"[{DateTime.Now}] {exception.StackTrace}");
        _logWriter.Flush();
    }
    
    public static void LogException(Exception exception, string message)
    {
        _logWriter.WriteLine($"[{DateTime.Now}] {message}");
        _logWriter.WriteLine($"[{DateTime.Now}] {exception.Message}");
        _logWriter.WriteLine($"[{DateTime.Now}] {exception.StackTrace}");
        _logWriter.Flush();
    }

    public static void Dispose()
    {
        _logWriter.Dispose();
    }
}