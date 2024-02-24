using Microsoft.EntityFrameworkCore;
using AuthenticatedAPI.Common.Data;
namespace AuthenticatedAPI.Common.Data;
public class SecurityContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        

        public SecurityContext(DbContextOptions<SecurityContext> options)
            : base(options)
        {
        }

        
    }