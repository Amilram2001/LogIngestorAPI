using DyteAssignment.Domain.DTO;

namespace DyteAssignment.Domain.Repository;

public interface ILogRepository
{
    public IEnumerable<Log> GetAll();

    public IEnumerable<Log> GetAllByFilters(LogSearch logSearch);
    public void Add(Log log);
}