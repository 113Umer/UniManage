using Microsoft.EntityFrameworkCore;
using WpfApp1;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Assignment> Assignments { get; set; }

    // Configure the database connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UniManage;Integrated Security=True;Trust Server Certificate=True"); // Add your SQL Server connection string
    }
}
