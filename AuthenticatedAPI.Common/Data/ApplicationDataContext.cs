using Microsoft.EntityFrameworkCore;
using AuthenticatedAPI.Common.Models;
namespace AuthenticatedAPI.Common.Data;
public class ApplicationDataContext : DbContext
{
        public DbSet<ProductModel> products { get; set; }
        public DbSet<CategoryModel> categories { get; set; }
        public DbSet<ShoppingCartModel> shoppingCarts { get; set; }

        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
            : base(options)
        {
        }
}