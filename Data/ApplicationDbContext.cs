using Microsoft.EntityFrameworkCore;
using reviewProject.Models;

namespace reviewProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        
    }
}
