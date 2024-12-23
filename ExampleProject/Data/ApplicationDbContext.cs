using ExampleProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<PageView> PageViews { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
