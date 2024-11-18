namespace TaskManagement.Models.Responses;

public class TaskResponse
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }
}
