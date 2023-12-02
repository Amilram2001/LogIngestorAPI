using DyteAssignment.Domain.Context;
using DyteAssignment.Domain.DTO;
using DyteAssignment.Domain.Entity;

namespace DyteAssignment.Domain.DAO;

public class LogDataAccessObject
{
    private readonly SqLiteDbContext _dbContext;

    public LogDataAccessObject(SqLiteDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Log> GetAllByFilters(LogSearch logSearch)
    {
        var queryable = _dbContext.Logs.AsQueryable();
        var to = logSearch.To;
        var from = logSearch.From;
        var level = logSearch.Level;
        var spanId = logSearch.SpanId;
        var commit = logSearch.Commit;
        var message = logSearch.Message;
        var traceId = logSearch.TraceId;
        var resourceId = logSearch.ResourceId;
        var parentResourceId = logSearch.ParentResourceId;
        
        if (from != DateTime.MinValue)
        {
            if (to == DateTime.MinValue)
            {
                to = DateTime.Now;
            }
            queryable = queryable.Where(log => log.Timestamp.Date >= from && log.Timestamp.Date <= to);
        }

        if (!string.IsNullOrEmpty(level))
        {
            queryable = queryable.Where(log => log.Level!.Contains(level));
        }

        if (!string.IsNullOrEmpty(spanId))
        {
            queryable = queryable.Where(log => log.SpanId!.Contains(spanId));
        }

        if (!string.IsNullOrEmpty(commit))
        {
            queryable = queryable.Where(log => log.Commit!.Contains(commit));
        }

        if (!string.IsNullOrEmpty(message))
        {
            queryable = queryable.Where(log => log.Message!.Contains(message));
        }

        if (!string.IsNullOrEmpty(traceId))
        {
            queryable = queryable.Where(log => log.TraceId!.Contains(traceId));
        }

        if (!string.IsNullOrEmpty(resourceId))
        {
            queryable = queryable.Where(log => log.ResourceId!.Contains(resourceId));
        }

        if (!string.IsNullOrEmpty(parentResourceId))
        {
            queryable = queryable.Where(log => log.ParentResourceId!.Contains(parentResourceId));
        }

        return queryable.Select(log => EntityToDto(log)).ToList();
    }

    public IEnumerable<Log> GetAll()
    {
        return _dbContext.Logs.Select(i => EntityToDto(i)).ToList();
    }

    public void Save(Log log)
    {
        var entity = new LogEntity()
        {
            Level = log.Level,
            SpanId = log.SpanId,
            Commit = log.Commit,
            Message = log.Message,
            TraceId = log.TraceId,
            ResourceId = log.ResourceId,
            Timestamp = log.Timestamp,
            ParentResourceId = log.ParentResourceId
        };
        _dbContext.Add(entity);
        _dbContext.SaveChangesAsync();
    }

    private static Log EntityToDto(LogEntity log)
    {
        return new Log
        {
            Level = log.Level,
            SpanId = log.SpanId,
            Commit = log.Commit,
            Message = log.Message,
            TraceId = log.TraceId,
            ResourceId = log.ResourceId,
            Timestamp = log.Timestamp,
            ParentResourceId = log.ParentResourceId
        };
    }
}