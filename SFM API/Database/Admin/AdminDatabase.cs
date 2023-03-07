using SFM_API.Database.DatabaseModels.AdminModels;
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
        CreateTables();
    }

    public void CreateTables()
    {
        Connection.CreateTable<AdminDataModel>();
    }
    
    public void AddAdmin(AdminDataModel admin)
    {
        Connection.Insert(admin);
    }
    
    public void RemoveAdmin(AdminDataModel admin)
    {
        Connection.Delete(admin);
    }
    
    public void UpdateAdmin(AdminDataModel admin)
    {
        Connection.Update(admin);
    }

    public List<AdminDataModel> GetAdminList()
    {
        return Connection.Table<AdminDataModel>().ToList();
    }
}