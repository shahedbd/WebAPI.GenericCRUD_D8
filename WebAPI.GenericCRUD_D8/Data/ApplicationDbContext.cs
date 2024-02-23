using Core.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.GenericCRUD_D8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Branch> Branch { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
