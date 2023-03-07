using SFM_API.Controllers.RequestModels;
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
}