using Microsoft.EntityFrameworkCore;

namespace WebApplicationExample
{
  public class dbContext : DbContext
  {
    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {
    }

    public DbSet<Alumno> Alumno { get; set; }
  }
}