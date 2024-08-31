using Microsoft.EntityFrameworkCore;
using project_one.Models;

namespace project_one.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Users> users { get; set; }

    }
}
