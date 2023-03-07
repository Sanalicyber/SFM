namespace SFM_API.Controllers.RequestModels;

public class SaveDataRequestModel
{
    public int UserId { get; set; }
    public int Salary { get; set; }
    public int Bonus { get; set; }
    public int TotalOutgoing { get; set; }
}