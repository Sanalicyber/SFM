using SQLite;

namespace SFM_API.Logger.Models;

public interface ILogModel
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
}