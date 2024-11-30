using Google.Protobuf.WellKnownTypes;

namespace TaskManagement.Models.Requests;

public class CreateTaskRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid StatusId { get; set; }
    public Timestamp Timestamp { get; set; }
    public Guid CreatorId { get; set; }
    //public Guid PerformerId { get; set; }
}

