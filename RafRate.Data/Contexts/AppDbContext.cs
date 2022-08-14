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
    }
}
