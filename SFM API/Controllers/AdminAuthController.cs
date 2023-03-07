using Microsoft.AspNetCore.Mvc;
using SFM_API.Core;
using SFM_API.Database.DatabaseModels.AdminModels;

namespace SFM_API.Controllers;

[ApiController]
[Route("[controller]")] //TODO: CHANGE THE NAME FOR SECURITY REASONS
public class AdminAuthController : ControllerBase
{
    [HttpGet(Name = "GetAdminList")]
    public IEnumerable<AdminDataModel> Get()
    {
        return MainManagement.AdminDatabase.GetAdminList();
    }
}