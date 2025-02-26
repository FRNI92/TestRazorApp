using TestRazorApp.Services;
using TestRazorApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestRazorApp.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ProductService _productService;

        // Dependency Injection för att få tillgång till ProductService
        public ProductsModel(ProductService productService)
        {
            _productService = productService;
        }

        // Lista för att lagra produkter som ska skickas till vyn
        public List<ProductRegistrationForm> Products { get; set; }

        public void OnGet()
        {
            // Hämta produkterna från ProductService och fyll Products-listan
            Products = _productService.GetProducts();
        }
    }
}
