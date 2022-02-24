using MedicalStore.Auth;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MedicalStore.Controllers
{
    [Route("product")]
    [ServiceFilter(typeof(UserFilter))]
    public class ProductController : Controller
    {
        private readonly IProductService ProductService;
        private readonly IProductRepository ProductRepository;

        public ProductController(IProductRepository productRepository, IProductService productService)
        {
            this.ProductService = productService;
            this.ProductRepository = productRepository;

        }

        [HttpGet("create")]
        public IActionResult CreateProduct()
        {
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

        [HttpGet("search")]
        public IActionResult SearchProduct(string name)
        {
            var product = ProductRepository.GetProductByName(name);
            this.ViewData["product"] = product;
            return View(Routers.UpdateProduct.Page);
        }

        [HttpGet("")]
        public IActionResult GetAllProducts()
        {
            var listProduct = (List<Product>)ProductRepository.GetAllProduct();
            this.ViewData["listProduct"] = listProduct;
            return View(Routers.Product.Page);
        }
    }
}
