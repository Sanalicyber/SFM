using SQLite;

namespace SFM_API.Database.User;

public class UserContentDatabase : DatabaseBase
{
    public string DatabaseName => "ContentDatabase.sqlite";
    private SQLiteConnection Connection;

    public UserContentDatabase()
    {
        if (!Directory.Exists(DatabaseFolderPath))
        {
            Directory.CreateDirectory(DatabaseFolderPath);
        }

        Connection = new SQLiteConnection(DatabaseFolderPath + DatabaseName);
        Console.WriteLine("UserContentDatabase created");
    }

    public void CreateTables()
    {
        // Connection.CreateTable<UserContentDataModel>();
    }
}