using Microsoft.EntityFrameworkCore;

namespace TaskManager.Model;

public class TmDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=LAPTOP-TV0BDEH0;initial catalog=TaskMaster;Trusted_Connection=True;TrustServerCertificate=Yes;Encrypt=false;");
    }

    public DbSet<Status> Status { get; set; }
    public DbSet<Task> Tasks { get; set; }
}
