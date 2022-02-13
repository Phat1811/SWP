using FluentValidation.Results;
using MedicalStore.Controllers.DTO;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Locale;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalStore.Controllers
{
    [Route("/api/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService CategoryService;
        private readonly ICategoryRepository CategoryRepository;

        public CategoryController(ICategoryService categoryService, ICategoryRepository categoryRepository)
        {
            this.CategoryService = categoryService;
            this.CategoryRepository = categoryRepository;
        }

        [HttpPost("create")]
        public IActionResult HandlerCreate([FromBody] CreateCategoryDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new CategoryDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var isExitCategory = this.CategoryRepository.GetCategortByName(body.Name);
            if(isExitCategory != null)
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_EXISTED, "name");
                return new BadRequestObjectResult(res.getResponse());
            }

            var category = new Category();
            category.CategoryId = Guid.NewGuid().ToString();
            category.Name = body.Name;
            category.Description = body.Description;
            category.Status = CategoryStatus.ACTIVE;
            category.CreateDate = DateTime.Now.ToShortDateString();

            this.CategoryService.CreateCategoryHandler(category);

            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_ADD_SUCCESS);
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("update")]
        public IActionResult HandlerUpdate([FromBody] CreateCategoryDTO body)
        {
            var res = new ServerApiResponse<string>();

            ValidationResult result = new CategoryDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }

            var isExitCategory = this.CategoryRepository.GetCategortByName(body.Name);
            if (isExitCategory != null)
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_EXISTED, "name");
                return new BadRequestObjectResult(res.getResponse());
            }
            var category = CategoryRepository.GetCategoryByID(body.CategoryId);
            category.Name = body.Name;
            category.Description = body.Description;

            this.CategoryService.UpdateCategoryInfoHandler(category);

            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_ADD_SUCCESS);
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("delete")]
        public IActionResult HandlerDelete([FromBody] CreateCategoryDTO body)
        {
            var res = new ServerApiResponse<string>();

            var category = CategoryRepository.GetCategoryByID(body.CategoryId);
            category.Status = CategoryStatus.INACTIVE;

            this.CategoryService.DeleteCategoryHandler(category);

            List<Product> list = CategoryRepository.GetProductByCategoryID(body.CategoryId);
            foreach(Product p in list)
            {
                CategoryRepository.DisableProductByID(p.ProductId);
            }

            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_ADD_SUCCESS);
            return new ObjectResult(res.getResponse());
        }

    }
}
