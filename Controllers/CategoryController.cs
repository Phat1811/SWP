using Microsoft.AspNetCore.Mvc;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using System.Collections.Generic;
using MedicalStore.Controllers.DTO;

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
        public IActionResult GetAllCategory()
        {
            var listCategory = (List<Category>)CategoryRepository.GetAllCategories();
            this.ViewData["listCategory"] = listCategory;

            return View(Routers.Category.Page);
        }

        [HttpGet("update")]
        public IActionResult CategoryProfile(string categoryId)
        {
            var category = CategoryRepository.GetCategoryByID(categoryId);
            this.ViewData["category"] = category;
            return View(Routers.CategoryProfile.Page);
        }

        [HttpGet("create")]
        public IActionResult CreateCategory()
        {
            return View(Routers.CreateCategory.Page);
        }

    }
}
