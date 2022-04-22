using Abc.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };

            return View(model);
        }
    }
}