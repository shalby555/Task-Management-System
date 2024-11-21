namespace TaskManegment.Core.Dtos;

public class TasksDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatorId { get; set; }
}
