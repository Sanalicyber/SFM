namespace SFM_API.Database;

public class DatabaseBase
{
    protected const string DatabaseFolderPath = "C://SFM/Database/";
    protected string DatabaseName { get; }
    protected string DatabasePath => DatabaseFolderPath + DatabaseName;
}