using Microsoft.AspNetCore.Mvc;
using SFM_API.Core;

namespace SFM_API.Controllers;

[ApiController]
[Route("[controller]")] //TODO: CHANGE THE NAME FOR SECURITY REASONS
public class AdminAuthController : ControllerBase
{
    [HttpGet(Name = "TryLoginAsAdmin")]
    public IActionResult TryLoginAsAdmin([FromQuery] string username, [FromQuery] string password)
    {
        var admin = MainManagement.AdminDatabase.GetAdmin(username);
        if (admin == null)
        {
            return NotFound();
        }

        if (admin.Password != password)
        {
            return Unauthorized();
        }

        return Ok(admin.Role);
    }
}