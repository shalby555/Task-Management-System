using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models.Requests;
using TaskManagement.Models.Responses;

namespace TaskManagement.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    //GET "api/users"
    [HttpPost]
    public ActionResult<Guid> Register([FromBody] RegisterUserRequest request)
    {
        var addedUserId = Guid.NewGuid();
        return Ok(addedUserId);
    }

    // "api/users/login"
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        return Ok();
    }

    // "api/users"
    [HttpGet]
    public ActionResult<List<UserResponse>> GetUsers()
    {
        List<UserResponse> users = new List<UserResponse>();
        return Ok(users);
    }

    // "api/:id"
    [HttpPut("{id}")]
    public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
    {
        return NoContent();
    }

    // "api/:id"
    [HttpDelete("{id}")]
    public IActionResult DeleteUser([FromRoute] Guid id)
    {
        return NoContent();
    }

    // "api/:id/deactivate"
    [HttpPatch("{id}/deactivate")]
    public IActionResult DeactivateUser([FromRoute] Guid id)
    {
        return NoContent();
    }


}
