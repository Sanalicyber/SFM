using SQLite;

namespace SFM_API.Database.DatabaseModels.UserModels;

public class UserIncomeModel
{
    [PrimaryKey, AutoIncrement, Unique] public int Id { get; set; }
    public int Salary { get; set; }
    public int Bonus { get; set; }
    public int TotalOutgoing { get; set; }
    [Unique] public int UserId { get; set; }
}