using Microsoft.AspNetCore.Mvc;
using SFM_API.Core;
using SFM_API.Database.DatabaseModels.UserModels;

namespace SFM_API.Controllers;

[ApiController]
[Route("[controller]")] //TODO: CHANGE THE NAME FOR SECURITY REASONS
public class UserAuthController
{
    [HttpGet(Name = "GetUserList")]
    public IEnumerable<UserDataModel> Get()
    {
        return MainManagement.UserDatabase.GetUserList();
    }
}