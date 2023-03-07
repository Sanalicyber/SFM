using Microsoft.AspNetCore.Mvc;
using SFM_API.Controllers.RequestModels;
using SFM_API.Core;
using SFM_API.Extensions;

namespace SFM_API.Controllers;

[ApiController, Route("[Controller]")]
public class UserProcessController : ControllerBase
{
    [HttpPost("SaveData", Name = "SaveData")]
    public IActionResult SaveData([FromBody] SaveDataRequestModel requestModel)
    {
        if (MainManagement.UserContentDatabase.IsIncomeExists(requestModel.UserId))
        {
            return Unauthorized();
        }

        if (MainManagement.UserContentDatabase.AddIncome(requestModel.ToIncomeModel()))
        {
            return Ok();
        }

        return BadRequest();
    }

    [HttpGet("GetIncome/{userId}", Name = "GetIncome")]
    public IActionResult GetIncome(int userId)
    {
        if (!MainManagement.UserContentDatabase.IsIncomeExists(userId))
        {
            return Unauthorized();
        }

        return Ok(MainManagement.UserContentDatabase.GetIncome(userId).ToIncomeResponseModel());
    }
}