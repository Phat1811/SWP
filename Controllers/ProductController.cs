using MedicalStore.Auth;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MedicalStore.Controllers
{
    [Route("product")]
    [ServiceFilter(typeof(UserFilter))]
    public class ProductController : Controller
    {
        private readonly IProductService ProductService;
        private readonly IUserService UserService;
        private readonly ICategoryService CategoryService;

        public ProductController(IProductService productService, IUserService userService, ICategoryService categoryService)
        {
            this.ProductService = productService;
            this.UserService = userService;
            this.CategoryService = categoryService;
        }

        [HttpGet("create")]
        public IActionResult CreateProduct()
        {
            var categories = CategoryService.GetListCategoriesByStatus(CategoryStatus.INACTIVE);
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
            var product = ProductService.GetProductById(productId);
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

        [HttpGet("detail")]
        public IActionResult ProductProfile(string productId)
        {
            var product = ProductService.GetProductById(productId);
            string categoryName = CategoryService.GetCategoryByID(product.CategoryId).Name;
            string shopName = UserService.GetUserById(product.ShopId).Name;
            this.ViewData["shopName"] = shopName;
            this.ViewData["categoryName"] = categoryName;
            this.ViewData["product"] = product;
            return View(Routers.ProductDetail.Page);
        }

        [HttpGet("search")]
        public IActionResult SearchProductByName(string name)
        {
            var product = ProductService.GetProductByName(name);
            this.ViewData["product"] = product;
            return View(Routers.SearchProduct.Page);
        }

        [HttpGet("")]
        public IActionResult GetProductsByUserRole(double min, double max, string name, string categoryId, int pageIndex = 0, int pageSize = 12)
        {
            var user = (User)this.ViewData["user"];
            List<Product> listProduct = new List<Product>();
            List<string> listShopName = new List<string>();
            int total = 0;
            if (user != null)
            {
                if (user.RoleId == "2")
                {
                    var (products, t) = this.ProductService.GetListProductByShopId(user.UserId, pageIndex, pageSize);
                    listProduct = products;
                    listProduct.Sort((x, y) => x.CreateDate.CompareTo(y.CreateDate));
                    total = t;
                }
                if (user.RoleId == "0")
                {
                    var categories = this.CategoryService.GetCategoryDropListRender(CategoryStatus.INACTIVE);
                    var allCategory = new SelectListItem()
                    {
                        Value = "",
                        Text = "All"
                    };

                    categories.Add(allCategory);
                    this.ViewData["categories"] = new SelectList(categories);

                    if (name == null) name = "";
                    if (categoryId == null) categoryId = "";
                    if (max < 0)
                    {
                        ServerResponse.SetFieldErrorMessage("max", CustomLanguageValidator.ErrorMessageKey.ERROR_GREATER_ZERO, this.ViewData);
                        max = 9999999;
                    }
                    if (max == 0)
                    {
                        max = 9999999;
                        var query = $"?min={min}&max={max}&name={name}&CategoryId={categoryId}";
                        return Redirect(Routers.Product.Link + query);
                    }

                    if (min < 0)
                    {
                        ServerResponse.SetFieldErrorMessage("min", CustomLanguageValidator.ErrorMessageKey.ERROR_GREATER_ZERO, this.ViewData);
                        min = 0;
                    }

                    if (min > max)
                    {
                        ServerResponse.SetErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_MIN_GREATER_MAX, this.ViewData);
                    }
                    var (products, count) = this.ProductService.GetProducts(pageIndex, pageSize, min, max, name, categoryId, CategoryStatus.INACTIVE);

                    products.Sort((x, y) => string.Compare(UserService.GetUserById(x.ShopId).Name, UserService.GetUserById(y.ShopId).Name));
                    foreach (Product p in products)
                    {
                        listShopName.Add(UserService.GetUserById(p.ShopId).Name);
                    }
                    listProduct = products;
                    total = count;
                }
            }

            this.ViewData["listShopName"] = listShopName;
            this.ViewData["listProduct"] = listProduct;
            this.ViewData["total"] = total;
            return View(Routers.Product.Page);
        }
    }
}
