using SFM_API.Database.DatabaseModels.UserModels;
using SQLite;

namespace SFM_API.Database.User;

public class UserDatabase : DatabaseBase
{
    protected override string DatabaseName => "UserDatabase.sqlite";

    private SQLiteConnection Connection;

    public UserDatabase()
    {
        if (!Directory.Exists(DatabaseFolderPath))
        {
            Directory.CreateDirectory(DatabaseFolderPath);
        }

        Connection = new SQLiteConnection(DatabasePath);
        Console.WriteLine("UserDatabase created");
        CreateTables();
    }

    public void CreateTables()
    {
        Connection.CreateTable<UserDataModel>();
    }
    
    public bool AddUser(UserDataModel user)
    {
        return Connection.Insert(user) == 1;
    }
    
    public bool RemoveUser(UserDataModel user)
    {
        return Connection.Delete(user) == 1;
    }
    
    public bool UpdateUser(UserDataModel user)
    {
        return Connection.Update(user) == 1;
    }
    
    public List<UserDataModel> GetUserList()
    {
        return Connection.Table<UserDataModel>().ToList();
    }
}