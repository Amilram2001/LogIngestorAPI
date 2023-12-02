using DyteAssignment.Domain.DTO;
using DyteAssignment.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DyteAssignment.Controllers.Log;

public class Post : LogControllerBase
{
    public Post(ILogRepository logRepository) : base(logRepository)
    { }

    [HttpPost]
    public IActionResult CreateLog(Domain.DTO.Log log)
    {
        LogRepository.Add(log);
        return Created("", log);
    }
    
    [HttpPost("filter")]
    public IActionResult GetAllFilteredLogs(LogSearch logSearch)
    {
        return Ok(LogRepository.GetAllByFilters(logSearch));
    }
}