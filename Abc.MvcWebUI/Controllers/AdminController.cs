using Abc.Business.Abstract;
using Abc.Entities.Concrete;
using Abc.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);

                TempData.Add("message", "Product was successfully added");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "Product was successfully updated");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", "Product was successfully updated");
            return RedirectToAction("Index");
        }
    }
}