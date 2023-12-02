using DyteAssignment.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DyteAssignment.Controllers.Log;

[Route("")]
[ApiController]
public class LogControllerBase : Controller
{
    protected readonly ILogRepository LogRepository;

    public LogControllerBase(ILogRepository logRepository)
    {
        LogRepository = logRepository;
    }
}