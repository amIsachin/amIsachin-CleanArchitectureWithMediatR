using Microsoft.EntityFrameworkCore;
using Shopping.Core.Entities;

namespace Shopping.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<EmployeeEntity> Employees { get; set; }
}