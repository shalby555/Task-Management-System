using Microsoft.EntityFrameworkCore;
using TaskManegment.Core.Dtos;

namespace TaskMenagment.DAL;

public class TaskManagementContext:DbContext
{
    public DbSet<Users> Users { get; set; }

    public DbSet<Task> Task { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Host=localhost;Port=5432;Database=Teast;Username=postgres;Password=postgres;";
        optionsBuilder.UseNpgsql(connectionString);
    }
}
