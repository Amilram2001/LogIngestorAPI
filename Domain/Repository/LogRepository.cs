using DyteAssignment.Domain.DAO;
using DyteAssignment.Domain.DTO;

namespace DyteAssignment.Domain.Repository;

public class LogRepository: ILogRepository
{
    private readonly LogDataAccessObject _logDao;

    public LogRepository(LogDataAccessObject logDao)
    {
        _logDao = logDao;
    }
    
    public IEnumerable<Log> GetAll()
    {
        return _logDao.GetAll();
    }

    public IEnumerable<Log> GetAllByFilters(LogSearch logSearch)
    {
        return _logDao.GetAllByFilters(logSearch);
    }

    public void Add(Log log)
    {
        _logDao.Save(log);
    }
}