using SFM_API.Controllers.RequestModels;
using SFM_API.Controllers.ResponseModels;
using SFM_API.Database.DatabaseModels.UserModels;

namespace SFM_API.Extensions;

public static class ModelExtensions
{
    public static UserDataModel ToUserDataModel(this RegisterUserDataModel model)
    {
        return new UserDataModel
        {
            Username = model.Username,
            Email = model.Email,
            Password = model.Password,
            Name = model.Name,
            Surname = model.Surname
        };
    }

    public static UserDataResponseModel ToUserDataResponseModel(this UserDataModel model)
    {
        return new UserDataResponseModel
        {
            Username = model.Username,
            Email = model.Email
        };
    }

    public static IEnumerable<UserDataResponseModel> ToUserDataResponseModel(this IEnumerable<UserDataModel> models)
    {
        return models.Select(model => model.ToUserDataResponseModel());
    }
    
    public static UserIncomeModel ToIncomeModel(this SaveDataRequestModel model)
    {
        return new UserIncomeModel
        {
            Salary = model.Salary,
            Bonus = model.Bonus,
            TotalOutgoing = model.TotalOutgoing,
            UserId = model.UserId
        };
    }
    
    public static UserIncomeResponseModel ToIncomeResponseModel(this UserIncomeModel model)
    {
        return new UserIncomeResponseModel
        {
            Salary = model.Salary,
            Bonus = model.Bonus,
            TotalOutgoing = model.TotalOutgoing
        };
    }
}