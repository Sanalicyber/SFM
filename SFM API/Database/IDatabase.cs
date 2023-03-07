namespace SFM_API.Database;

public interface IDatabase
{
    protected const string DatabaseFolderPath = "C://SFM/Database/";
    protected string DatabaseName { get; }
    
    protected string DatabasePath => DatabaseFolderPath + DatabaseName;
}