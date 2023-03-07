using SQLite;

namespace SFM_API.Database.DatabaseModels;

public class BaseDatabaseModel
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
}