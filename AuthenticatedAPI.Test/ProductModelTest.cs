using AuthenticatedAPI.Common.Models;
namespace AuthenticatedAPI.Test;

public class ProductModelTest
{
    [Fact]
    public void CanInstantiateProductModel()
        {
            
            var product = new ProductModel();

          
            Assert.NotNull(product);
        }

        [Fact]
        public void IdDefaultValueIsZero()
        {
            
            var product = new ProductModel();

            
            Assert.Equal(0, product.Id);
        }

        [Fact]
        public void CategoryDefaultValueIsNull()
        {
            
            var product = new ProductModel();

           
            Assert.Null(product.Category);
        }

        [Fact]
        public void SetAndGetProperties()
        {
            var category = new CategoryModel { Id = 1, Name = "Electronics" };
            var product = new ProductModel
            {
                Id = 1,
                Name = "Laptop",
                Price = 999.99m,
                Description = "High-performance laptop",
                Category = category
            };

            
            Assert.Equal(1, product.Id);
            Assert.Equal("Laptop", product.Name);
            Assert.Equal(999.99m, product.Price);
            Assert.Equal("High-performance laptop with SSD storage", product.Description);
            Assert.NotNull(product.Category);
            Assert.Equal(1, product.Category.Id);
            Assert.Equal("Electronics", product.Category.Name);
        }
        
}