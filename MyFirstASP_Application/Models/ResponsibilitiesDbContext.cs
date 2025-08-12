using Microsoft.EntityFrameworkCore;

namespace MyFirstASP_Application.Models
{
    public class ResponsibilitiesDbContext : DbContext
    {
        public DbSet<Responsibility> responsibilities { get; set; }

        public ResponsibilitiesDbContext(DbContextOptions<ResponsibilitiesDbContext> options) : base(options)
        {

        }
    }
}
