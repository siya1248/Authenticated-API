namespace AuthenticatedAPI.Common;

public class ShoppingCartModel
{
    public int ID {get; set;}
    public string User {get; set;}
    public List<ProductModel> products {get; set;}

    public ShoppingCartModel()
    {
        products = new List<ProductModel>();
    }
}
