using MedicalStore.Models;
using Microsoft.AspNetCore.Mvc;
using MedicalStore.Auth;
using System;
using MedicalStore.Service.Interface;
using MedicalStore.DAO.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Http;


namespace MedicalStore.Controllers
{
    [Route("")]
    [ServiceFilter(typeof(AuthGuardGuest))]

    public class HomeController : Controller
    {
        private const string CartSession = "CartSession";
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        private readonly ICategoryService CategoryService;


        public HomeController(IProductService productService, ICategoryService categoryService, ICartService cartService)
        {
            this.ProductService = productService;
            this.CategoryService = categoryService;
            this.CartService = cartService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var user = (User)this.ViewData["user"];
            if (user.RoleId == "0")
            {
                return Redirect(Routers.Product.Link);
            }
            if (user.RoleId == "2")
            {
                return Redirect(Routers.Product.Link);
            }

            var cart = this.HttpContext.Session.GetString(CartSession) ?? "";

            var list = this.CartService.convertStringToCartItem(cart);

            var getCart = this.CartService.GetCartItems(list);
            this.ViewData["cartItems"] = getCart;

            Console.WriteLine(this.ViewData["user"]);
            var products = this.ProductService.GetProducts();
            this.ViewData["products"] = products;
            return View(Routers.Home.Page);
        }

    }
}
