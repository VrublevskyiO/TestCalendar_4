using Microsoft.EntityFrameworkCore;
using TestCalendar_4.Domain.Entity;

namespace TestCalendar_4.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<EventEntity> Events { get; set; }
}