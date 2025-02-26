using TestRazorApp.Services;
using TestRazorApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestRazorApp.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ProductService _productService;

        // Dependency Injection f�r att f� tillg�ng till ProductService
        public ProductsModel(ProductService productService)
        {
            _productService = productService;
        }

        // Lista f�r att lagra produkter som ska skickas till vyn
        public List<ProductRegistrationForm> Products { get; set; }

        public void OnGet()
        {
            // H�mta produkterna fr�n ProductService och fyll Products-listan
            Products = _productService.GetProducts();
        }
    }
}
