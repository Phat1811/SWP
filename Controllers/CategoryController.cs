using Microsoft.AspNetCore.Mvc;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using System.Collections.Generic;
using MedicalStore.Controllers.DTO;
using System.Linq;

namespace MedicalStore.Controllers
{
    [Route("category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService CategoryService;
        private readonly ICategoryRepository CategoryRepository;

        public CategoryController(ICategoryService categoryService, ICategoryRepository categoryRepository)
        {
            this.CategoryService = categoryService;
            this.CategoryRepository = categoryRepository;
        } 

        [HttpGet("")]
        public IActionResult GetAllCategory(string sortBy, int pageIndex = 0, int pageSize = 12)
        {
            var (categories, total) = this.CategoryService.GetAllCategories(pageIndex, pageSize);
            categories.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            if (sortBy == "createDateIncreasing")
            {
                categories.Sort((x, y) => x.CreateDate.CompareTo(y.CreateDate));
            }
            if (sortBy == "createDateDescending")
            {
                categories.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            }
            if (sortBy == "nameIncreasing")
            {
                categories.Sort((x, y) => string.Compare(y.Name, x.Name));
            }
            if (sortBy == "nameDescending")
            {
                categories.Sort((x, y) => string.Compare(x.Name, y.Name));
            }
            this.ViewData["listCategory"] = categories;
            this.ViewData["total"] = total;
            return View(Routers.Category.Page);
        }

        [HttpGet("update")]
        public IActionResult UpdateCategory(string categoryId)
        {
            var category = CategoryRepository.GetCategoryByID(categoryId);
            this.ViewData["category"] = category;
            return View(Routers.CategoryUpdate.Page);
        }

        [HttpGet("profile")]
        public IActionResult CategoryProfile(string categoryId)
        {
            var category = CategoryRepository.GetCategoryByID(categoryId);
            var listProductByCategoryId = (List<Product>)CategoryRepository.GetProductByCategoryID(categoryId);
            this.ViewData["category"] = category;
            this.ViewData["listProductByCategoryId"] = listProductByCategoryId;
            return View(Routers.CategoryProfile.Page);
        }

        [HttpGet("create")]
        public IActionResult CreateCategory()
        {
            return View(Routers.CreateCategory.Page);
        }

    }
}
