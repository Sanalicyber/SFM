using SQLite;

namespace SFM_API.Database.DatabaseModels;

public interface IDatabaseModel
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
}