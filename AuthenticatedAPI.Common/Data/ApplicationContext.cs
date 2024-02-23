using Microsoft.EntityFrameworkCore;
namespace AuthenticatedAPI.Common.Data
public class ApplicationContext : DbContext
{
        public DbSet<ProductModel> products { get; set; }
        public DbSet<CategoryModel> categories { get; set; }
        public DbSet<ShoppingCartModel> shoppingCarts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
}