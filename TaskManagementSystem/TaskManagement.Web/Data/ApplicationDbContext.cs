using Microsoft.EntityFrameworkCore;
using TaskManagement.Web;

namespace TaskManagement.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}
