using Microsoft.EntityFrameworkCore;
using SchoolApi.Data.Mapping;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}