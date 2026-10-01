using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RafRate.Data.Entities.Users;

namespace RafRate.Data.Contexts;

public class AppDbContext : IdentityDbContext<UserEntity, UserRoles, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserEntity>(b =>
        {
            b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
        });

        builder.Entity<UserRoles>(b =>
        {
            b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
        });
    }
    
    public DbSet<UserEntity> Users { get; set; } = null!;
}