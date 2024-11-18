namespace TaskManagement.Models.Requests;

public class CreateTaskRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}

