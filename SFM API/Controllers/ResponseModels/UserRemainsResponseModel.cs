namespace SFM_API.Controllers.ResponseModels;

public class UserRemainsResponseModel
{
    public int Remains { get; set; }

    public UserRemainsResponseModel(int remains)
    {
        Remains = remains;
    }
}