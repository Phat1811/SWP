using MedicalStore.Auth;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MedicalStore.Controllers
{
    [Route("product")]
    [ServiceFilter(typeof(UserFilter))]
    public class ProductController : Controller
    {
        private readonly ICategoryRepository CategoryRepository;
        private readonly IProductService ProductService;
        private readonly IProductRepository ProductRepository;
        private readonly IUserRepository UserRepository;

        public ProductController(IProductRepository productRepository, IProductService productService, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            this.ProductService = productService;
            this.ProductRepository = productRepository;
            this.CategoryRepository = categoryRepository;
            this.UserRepository = userRepository;
        }

        [HttpGet("create")]
        public IActionResult CreateProduct()
        {
            var categories = CategoryRepository.GetListCategoriesByStatus(CategoryStatus.INACTIVE);
            this.ViewData["listCategory"] = new SelectList(categories);
            var product = (Product)this.ViewData["product"];
            if (product != null)
            {
                return Redirect(Routers.Home.Link);
            }
            return View(Routers.CreateProduct.Page);
        }

        [HttpGet("update")]
        public IActionResult UpdateProduct(string productId)
        {
            var product = ProductRepository.GetProductById(productId);
            this.ViewData["product"] = product;
            return View(Routers.UpdateProduct.Page);
        }

        [HttpGet("delete")]
        public IActionResult DeleteProduct()
        {
            var product = (Product)this.ViewData["product"];
            if (product != null)
            {
                return Redirect(Routers.Home.Link);
            }
            return View(Routers.Product.Page);
        }

        [HttpGet("profile")]
        public IActionResult ProductProfile(string productId)
        {
            var product = ProductRepository.GetProductById(productId);
            string categoryName = CategoryRepository.GetCategoryByID(product.CategoryId).Name;
            string shopName = UserRepository.GetUserById(product.ShopId).Name;
            this.ViewData["shopName"] = shopName;
            this.ViewData["categoryName"] = categoryName;
            this.ViewData["product"] = product; 
            return View(Routers.ProductProfile.Page);
        }

        [HttpGet("search")]
        public IActionResult SearchProductByName(string name)
        {
            var product = ProductRepository.GetProductByName(name);
            this.ViewData["product"] = product;
            return View(Routers.SearchProduct.Page);
        }

        [HttpGet("")]
        public IActionResult GetProductsByUserRole()
        {
            var user = (User)this.ViewData["user"];
            List<Product> listProduct = new List<Product>();
            List<string> listShopName = new List<string>();
            if(user != null)
            {
                if(user.RoleId == "2")
                {
                    var list = (List<Product>)ProductRepository.GetListProductByShopId(user.UserId);
                    listProduct = list;
                }
                if(user.RoleId == "0")
                {
                    var list = (List<Product>)ProductRepository.GetAllProduct();
                    list.Sort((x, y) => string.Compare(UserRepository.GetUserById(x.ShopId).Name, UserRepository.GetUserById(y.ShopId).Name));
                    foreach(Product p in list)
                    {
                        listShopName.Add(UserRepository.GetUserById(p.ShopId).Name);
                    }
                    listProduct = list;
                }
            }
            this.ViewData["listShopName"] = listShopName;
            this.ViewData["listProduct"] = listProduct;
            return View(Routers.Product.Page);
        }
    }
}
