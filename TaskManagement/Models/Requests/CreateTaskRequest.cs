using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models.Requests;

public class CreateTaskRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TimestampAttribute TimeAttribute { get; set; }
    //public TaskStatus Status { get; set; }
}
