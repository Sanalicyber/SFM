using Microsoft.AspNetCore.Mvc;
using SFM_API.Controllers.RequestModels;
using SFM_API.Core;
using SFM_API.Extensions;
using SFM_API.Logger;

namespace SFM_API.Controllers;

[ApiController]
[Route("[controller]")] //TODO: CHANGE THE NAME FOR SECURITY REASONS
public class UserAuthController : ControllerBase
{
    [HttpGet("GetUsers", Name = "GetUserList")]
    public IActionResult Get()
    {
        //log process
        SLogger.Log("User List requested.");
        return Ok(MainManagement.UserDatabase.GetUserList().ToUserDataResponseModel());
    }

    [HttpGet("GetUser.{id}", Name = "GetUser")]
    public IActionResult Get(int id)
    {
        var user = MainManagement.UserDatabase.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        //log user data
        SLogger.Log($"User {user.Username} with email {user.Email} requested his data.");
        return Ok(user.ToUserDataResponseModel());
    }

    [HttpPost("RegisterUser", Name = "RegisterUser")]
    public IActionResult RegisterUserPost([FromBody] RegisterUserDataModel user)
    {
        if (MainManagement.UserDatabase.AddUser(user.ToUserDataModel()))
        {
            SLogger.Log($"User {user.Username} registered with email {user.Email}.");
            return Ok();
        }
        
        return BadRequest();
    }

    [HttpGet("{username}, {password}", Name = "TryLoginAsUser")]
    public IActionResult TryLoginAsUser(string username, string password)
    {
        var user = MainManagement.UserDatabase.GetUser(username);
        if (user == null)
        {
            return NotFound();
        }

        if (user.Password != password)
        {
            SLogger.Log($"User {user.Username} tried to login with wrong password.");
            return Unauthorized();
        }

        SLogger.Log($"User {user.Username} logged in.");
        return Ok();
    }
}