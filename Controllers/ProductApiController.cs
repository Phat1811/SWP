using FluentValidation.Results;
using MedicalStore.Auth;
using MedicalStore.Controllers.DTO;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils.Common;
using MedicalStore.Utils.Locale;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalStore.Controllers
{
    [Route("/api/product")]
    [ServiceFilter(typeof(AuthGuard))]
    public class ProductApiController : Controller
    {
        private readonly IProductService ProductService;
        private readonly IProductRepository ProductRepository;
        private readonly ICategoryRepository CategoryRepository;
        public ProductApiController(IProductRepository productRepository, IProductService productService, ICategoryRepository categoryRepository)
        {
            this.ProductService = productService;
            this.ProductRepository = productRepository;
            this.CategoryRepository = categoryRepository;
        }

        [HttpPost("create")]
        public IActionResult HandleCreateProduct([FromBody] CreateProductDTO body)
        
        {
            if(body == null)
            {
                body = new CreateProductDTO();
            }
            var res = new ServerApiResponse<string>();
            ValidationResult result = new CreateProductDTOValidator().Validate(body);
            
            if(!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            User user = (User)this.ViewData["user"];
            var product = new Product();
            product.ProductId = Guid.NewGuid().ToString();
            product.Name = body.Name.Trim();
            product.Description = body.Description.Trim();
            product.OriginalPrice = body.OriginalPrice;
            product.RetailPrice = body.RetailPrice;
            product.Quantity = body.Quantity;
            product.ImageUrl = body.ImageUrl.Trim();
            product.CategoryId = body.CategoryId;
            product.ShopId = user.UserId;
            product.CreateDate = DateTime.Now.ToShortDateString();
            product.Status = ProductStatus.ACTIVE;


            this.ProductService.CreateProductHandler(product);
            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_REGISTER_SUCCESS);
            return new ObjectResult(res.getResponse());
        }

        [HttpPost("update")]
        public IActionResult HandleUpdateProduct([FromBody] UpdateProductDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new UpdateProductDTOValidator().Validate(body);
            if (!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            var product = this.ProductRepository.GetProductById(body.ProductId);
            if(product == null)
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_NOT_FOUND, "ProductID");
                return new NotFoundObjectResult(res.getResponse());
            }

            var isExistCategory = this.CategoryRepository.GetCategoryByID(body.CategoryId);
            if (isExistCategory == null)
            {
                res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_NOT_FOUND, "CategoryID");
                return new NotFoundObjectResult(res.getResponse());
            }

            if (product.Name != body.ProductName)
            {
                var isExistProduct = this.ProductRepository.GetProductByName(body.ProductName);
                if (isExistProduct != null)
                {
                    res.setErrorMessage(CustomLanguageValidator.ErrorMessageKey.ERROR_EXISTED, "Name");
                    return new BadRequestObjectResult(res.getResponse());
                }
            }

            product.Name = body.ProductName.Trim();
            product.Description = body.ProductDescription.Trim();
            product.OriginalPrice = body.OriginalPrice;
            product.RetailPrice = body.RetailPrice;
            product.Quantity = body.Quantity;
            product.ImageUrl = body.ImageUrl.Trim();

            this.ProductService.UpdateProductHandler(product);


            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_ADD_SUCCESS);
            return new ObjectResult(res.getResponse());

        }

        [HttpPost("delete")]
        public IActionResult HandleDeleteProduct([FromBody] CreateProductDTO body)
        {
            var res = new ServerApiResponse<string>();

            var product = ProductRepository.GetProductById(body.ProductId);
            product.Status = ProductStatus.INACTIVE;

            this.ProductService.DeleteProductHandler(product);

            res.setMessage(CustomLanguageValidator.MessageKey.MESSAGE_ADD_SUCCESS);
            return new ObjectResult(res.getResponse());
        }
    }

    
}
