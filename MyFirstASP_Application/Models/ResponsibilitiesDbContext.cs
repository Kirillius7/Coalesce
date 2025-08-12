using Microsoft.EntityFrameworkCore;

namespace MyFirstASP_Application.Models
{
    public class ResponsibilitiesDbContext : DbContext
    {
        public DbSet<Responsibility> expenses { get; set; }

        public ResponsibilitiesDbContext(DbContextOptions<ResponsibilitiesDbContext> options) : base(options)
        {

        }
    }
}
