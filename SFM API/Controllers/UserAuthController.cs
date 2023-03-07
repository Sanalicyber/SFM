using Microsoft.AspNetCore.Mvc;
using SFM_API.Controllers.RequestModels;
using SFM_API.Core;
using SFM_API.Database.DatabaseModels.UserModels;
using SFM_API.Extensions;

namespace SFM_API.Controllers;

[ApiController]
[Route("[controller]")] //TODO: CHANGE THE NAME FOR SECURITY REASONS
public class UserAuthController : ControllerBase
{
    [HttpGet(Name = "GetUserList")]
    public IActionResult Get()
    {
        return Ok(MainManagement.UserDatabase.GetUserList());
    }

    [HttpGet("{id}", Name = "GetUser")]
    public IActionResult Get(int id)
    {
        var user = MainManagement.UserDatabase.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPost(Name = "RegisterUser")]
    public IActionResult RegisterUserPost([FromBody] RegisterUserDataModel user)
    {
        if (MainManagement.UserDatabase.AddUser(user.ToUserDataModel()))
        {
            return Ok();
        }

        return BadRequest();
    }

    [HttpGet(Name = "TryLogin")]
    public IActionResult TryLogin([FromQuery] string username, [FromQuery] string password)
    {
        var user = MainManagement.UserDatabase.GetUser(username);
        if (user == null)
        {
            return NotFound();
        }

        if (user.Password != password)
        {
            return Unauthorized();
        }

        return Ok();
    }
}