using SFM_API.Database.DatabaseModels.UserModels;
using SQLite;

namespace SFM_API.Database.User;

public class UserContentDatabase : DatabaseBase
{
    protected override string DatabaseName => "ContentDatabase.sqlite";
    private SQLiteConnection Connection;

    public UserContentDatabase()
    {
        if (!Directory.Exists(DatabaseFolderPath))
        {
            Directory.CreateDirectory(DatabaseFolderPath);
        }

        Connection = new SQLiteConnection(DatabasePath);
        Console.WriteLine("UserContentDatabase created");
        CreateTables();
    }

    public void CreateTables()
    {
        Connection.CreateTable<UserIncomeModel>();
    }
    
    public bool IsIncomeExists(int userId)
    {
        return Connection.Table<UserIncomeModel>().Any(x => x.UserId == userId);
    }
    
    public bool AddIncome(UserIncomeModel incomeModel)
    {
        return Connection.Insert(incomeModel) == 1;
    }
    
    public void UpdateIncome(UserIncomeModel incomeModel)
    {
        Connection.Update(incomeModel);
    }
    
    public void DeleteIncome(UserIncomeModel incomeModel)
    {
        Connection.Delete(incomeModel);
    }
    
    public UserIncomeModel GetIncome(int userId)
    {
        return Connection.Table<UserIncomeModel>().FirstOrDefault(x => x.UserId == userId);
    }
}