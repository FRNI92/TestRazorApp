using TestRazorApp.Models;

namespace TestRazorApp.Services;

public class ProductService
{
    private static List<ProductRegistrationForm> products = new List<ProductRegistrationForm>
        {
            new ProductRegistrationForm { Id = 1, Name = "Product 1", Price = 100.00m },
            new ProductRegistrationForm { Id = 2, Name = "Product 2", Price = 150.00m },
            new ProductRegistrationForm { Id = 3, Name = "Product 3", Price = 200.00m }
        };

    public List<ProductRegistrationForm> GetProducts()
    {
        return products;
    }
}
