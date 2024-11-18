using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models.Requests;

namespace TaskManagement.Controllers;

[Route("\"api/task")]
[ApiController]
public class TasksController : ControllerBase
{
    //GET "api/task"
    [HttpPost]
    public ActionResult<Guid> Register([FromBody] CreateTaskRequest request)
    {
        var addedTaskId = Guid.NewGuid();
        return Ok(addedTaskId);
    }
}
