namespace DyteAssignment.Domain.DTO;

public class LogSearch
{
    public DateTime To { get; set; }
    public DateTime From { get; set; }
    public string? Level { get; set; }
    public string? SpanId { get; set; }
    public string? Commit { get; set; }
    public string? Message { get; set; }
    public string? TraceId { get; set; }
    public string? ResourceId { get; set; }
    public string? ParentResourceId { get; set; }
}