using FluentValidation.Results;
using MedicalStore.Controllers.DTO;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Locale;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalStore.Controllers
{
    [Route("/api/category")]
    public class CategoryApiController : Controller
    {
        private readonly ICategoryService CategoryService;
        private readonly ICategoryRepository CategoryRepository;

        public CategoryApiController(ICategoryService categoryService, ICategoryRepository categoryRepository)
        {
            this.CategoryService = categoryService;
            this.CategoryRepository = categoryRepository;
        }

        [HttpPost("create")]
        public IActionResult HandlerCreate([FromBody] CreateCategoryDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new CreateCategoryDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var isExistCategory = this.CategoryRepository.GetCategortByName(body.Name.Trim());
            if (isExistCategory != null)
            {
                res.setErrorMessage("Category Name is already exist!!");
                return new BadRequestObjectResult(res.getResponse());
            }

            var category = new Category();
            category.CategoryId = Guid.NewGuid().ToString();
            category.Name = body.Name.Trim();
            category.Description = body.Description.Trim();
            category.Status = CategoryStatus.ACTIVE;
            category.CreateDate = DateTime.Now.ToUniversalTime().ToString();

            this.CategoryService.CreateCategoryHandler(category);

            res.setMessage("Create Category success");
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("update")]
        public IActionResult HandlerUpdate([FromBody] UpdateCategoryDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new UpdateCategoryDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            var category = CategoryRepository.GetCategoryByID(body.CategoryId);
            if (body.Name.Trim() != category.Name) {
            var isExistCategory = this.CategoryRepository.GetCategortByName(body.Name.Trim());
            if (isExistCategory != null)
            {
                    res.setErrorMessage("Category Name is already exist!!");
                    return new BadRequestObjectResult(res.getResponse());
            }
            }
            category.Name = body.Name.Trim();
            category.Description = body.Description.Trim();
            this.CategoryService.UpdateCategoryInfoHandler(category);

            res.setMessage("Update Category success");
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("delete")]
        public IActionResult HandlerDelete([FromBody] UpdateCategoryDTO body)
        {
            var res = new ServerApiResponse<string>();
            var category = CategoryRepository.GetCategoryByID(body.CategoryId);
            category.Status = CategoryStatus.INACTIVE;

            this.CategoryService.DeleteCategoryHandler(category);

            List<Product> list = CategoryRepository.GetProductByCategoryID(body.CategoryId);
            foreach (Product p in list)
            {
                CategoryRepository.DisableProductByID(p.ProductId);
            }

            res.setMessage("Delete Category success");
            return new ObjectResult(res.getResponse());
        }
    }
}
