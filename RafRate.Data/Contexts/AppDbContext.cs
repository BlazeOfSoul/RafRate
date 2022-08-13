using Microsoft.EntityFrameworkCore;
using RafRate.Data.Entities;

namespace RafRate.Data.Contexts
{
    public class AppDbContext : DbContext
    {
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
            ConnectionStringContext stringContext = new();
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringContext.ConnectionString);
            }
        }
    }
}
