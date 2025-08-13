using Microsoft.EntityFrameworkCore;

namespace MyFirstASP_Application.Models
{
    public class DatesDbContext : DbContext
    {
        public DbSet<Date> dates { get; set; }

        public DatesDbContext(DbContextOptions<DatesDbContext> options) : base(options) { }
    }
}
