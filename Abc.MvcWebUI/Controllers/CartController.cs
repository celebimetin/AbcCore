using Abc.Business.Abstract;
using Abc.Entities.Concrete;
using Abc.MvcWebUI.Models;
using Abc.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Abc.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartSessionService _cartSessionService;
        private readonly ICartService _cartService;
        private readonly IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SertCart(cart);

            TempData.Add("message", String.Format("Your Product, {0}, was successfully added to the cart", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");
        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel cartSummary = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(cartSummary);
        }

        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SertCart(cart);

            TempData.Add("message", String.Format("Your Product was successfully removed from the cart"));

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };

            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0}, your order is in process", shippingDetails.FirstName));
            return View();
        }
    }
}