using Microsoft.EntityFrameworkCore;
namespace AuthenticatedAPI.Common.Data
public class SecurityContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        // Add DbSet properties for other security entities as needed

        public SecurityDbContext(DbContextOptions<SecurityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships, constraints, etc.
            // For example:
            // modelBuilder.Entity<User>().HasKey(u => u.Id);
            // modelBuilder.Entity<User>().Property(u => u.UserName).IsRequired();
            // modelBuilder.Entity<User>().HasMany(u => u.Roles).WithMany(r => r.Users);
        }
    }