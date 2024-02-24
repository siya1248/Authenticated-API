namespace AuthenticatedAPI.Test;

public class ShoppingCartModelTest
{
    [Fact]
    public void ShoppingCartModel_Instance()
        {
            
            var cart = new ShoppingCartModel();

            Assert.NotNull(cart);
        }

        [Fact]
        public void ShoppingCartModel_IdValueIsZero()
        {

            var cart = new ShoppingCartModel();

            Assert.Equal(0, cart.ID);
        }

        [Fact]
        public void ShoppingCartModel_UserValueIsNull()
        {
            var cart = new ShoppingCartModel();

            Assert.Null(cart.User);
        }

        [Fact]
        public void ShoppingCartModel_ProductsInitialized()
        {

            var cart = new ShoppingCartModel();

            Assert.NotNull(cart.products);
            Assert.Empty(cart.products);
        }

}