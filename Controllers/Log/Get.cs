using DyteAssignment.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DyteAssignment.Controllers.Log;

public class Get : LogControllerBase
{
    public Get(ILogRepository logRepository) : base(logRepository)
    { }
    
    [HttpGet]
    public IActionResult GetAllLogs()
    {
        return Ok(LogRepository.GetAll());
    }
}