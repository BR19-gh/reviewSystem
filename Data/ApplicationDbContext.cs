using Microsoft.EntityFrameworkCore;
using reviewProject.Models;

namespace reviewProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Question> Question { get; set; }
        public DbSet<Review> Review { get; set; }
        
    }
}
