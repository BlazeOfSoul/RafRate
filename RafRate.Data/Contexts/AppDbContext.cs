using Microsoft.EntityFrameworkCore;
using RafRate.Data.Entities;

namespace RafRate.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        //TODO class with connction string
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<UserEntity> Users { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));
            }
        }
    }
}
