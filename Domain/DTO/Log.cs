using System.ComponentModel.DataAnnotations;

namespace DyteAssignment.Domain.DTO;

public class Log
{
    [Required] public string? Level { get; set; }
    [Required] public string? SpanId { get; set; }
    [Required] public string? Commit { get; set; }
    [Required] public string? Message { get; set; }
    [Required] public string? TraceId { get; set; }
    [Required] public string? ResourceId { get; set; }
    [Required] public DateTime Timestamp { get; set; }
    [Required] public string? ParentResourceId { get; set; }
}