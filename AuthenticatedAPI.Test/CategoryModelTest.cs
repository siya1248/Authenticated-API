namespace AuthenticatedAPI.Test;

public class CategoryModelTest
{
    [Fact]
    public void CategoryModelInitiated()
        {
            
            var category = new CategoryModel();

            Assert.NotNull(category);
        }

        [Fact]
        public void CategoryId_DefaultValueIsZero()
        {
         
            var category = new CategoryModel();

            Assert.Equal(0, category.Id);
        }

        [Fact]
        public void CategoryDescription_DefaultValueIsNull()
        {

            var category = new CategoryModel();

            Assert.Null(category.Description);
        }

        [Fact]
        public void Category_SetAndGetProperties()
        {

            var category = new CategoryModel
            {
                Id = 1,
                Description = "Test Description"
            };

            Assert.Equal(1, category.Id);
            Assert.Equal("Test Description", category.Description);
        }
}