using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models.Requests;
using TaskManagement.Models.Responses;

namespace TaskManagement.Controllers;

[Route("api/task")]
[ApiController]
public class TasksController : ControllerBase
{
    //POST "api/tasks/create"
    [HttpPost]
    public ActionResult<Guid> Create([FromBody] CreateTaskRequest request)
    {
        var addedTaskId = Guid.NewGuid();
        return Ok(addedTaskId);
    }

    //GET "api/tasks"
    [HttpGet]
    public ActionResult<List<UserResponse>> GetUsers()
    {
        List<UserResponse> users = new List<UserResponse>();
        return Ok(users);
    }

    //GET "api/tasks"
    [HttpGet]
    public ActionResult<List<TaskResponse>> GetTasks()
    {
        List<TaskResponse> tasks = new List<TaskResponse>();
        return Ok(tasks);
    }

    //PUT "api/:id"
    [HttpPut("{id}")]
    public IActionResult UpdateTask([FromRoute] Guid id, [FromBody] UpdateTaskRequest request)
    {
        return NoContent();
    }

    //PATCH "api/:id/status"
    [HttpPatch("{id}/status")]
    public IActionResult StatusTask([FromRoute] Guid id)
    {
        return NoContent(); 
    }

    //DELETE "api/:id"
    [HttpDelete("{id}")]
    public IActionResult DeleteTask([FromRoute] Guid id)
    {   
        return NoContent();
    }
}
