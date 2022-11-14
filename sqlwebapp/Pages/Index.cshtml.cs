using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlwebapp.models;
using sqlwebapp.Services;

namespace sqlwebapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Product> Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products=productService.GetProducts();

        }
    }
}