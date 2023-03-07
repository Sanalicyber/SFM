using SQLite;

namespace SFM_API.Database.Admin;

public class AdminDatabase : DatabaseBase
{
    public string DatabaseName => "AdminDatabase.sqlite";
    private SQLiteConnection Connection;

    public AdminDatabase()
    {
        if (!Directory.Exists(DatabaseFolderPath))
        {
            Directory.CreateDirectory(DatabaseFolderPath);
        }

        Connection = new SQLiteConnection(DatabaseFolderPath + DatabaseName);
        Console.WriteLine("AdminDatabase created");
    }
}