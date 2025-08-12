using Microsoft.EntityFrameworkCore;

namespace MyFirstASP_Application.Models
{
    public class ExpensesDbContext : DbContext
    {
        public DbSet<Expense> expenses { get; set; }

        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) : base(options)
        {
            
        }
    }
}
