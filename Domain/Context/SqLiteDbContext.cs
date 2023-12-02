using DyteAssignment.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace DyteAssignment.Domain.Context;

public class SqLiteDbContext : DbContext
{
    public required DbSet<LogEntity> Logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Datasource = data.db");
    }
}