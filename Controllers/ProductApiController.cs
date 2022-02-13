using FluentValidation.Results;
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
    public class ProductApiController : Controller
    {
        private readonly IProductService ProductService;
        private readonly IProductRepository ProductRepository;

        public ProductApiController(IProductRepository productRepository, IProductService productService)
        {
            this.ProductService = productService;
            this.ProductRepository = productRepository;

        }

        [HttpPost("create")]
        public IActionResult HandleCreateProduct([FromBody] CreateProductDTO body)
        {
            var res = new ServerApiResponse<string>();
            ValidationResult result = new CreateProductDTOValidator().Validate(body);
            if(!result.IsValid)
            {
                res.mapDetails(result);
                return new BadRequestObjectResult(res.getResponse());
            }
            var product = new Product();
            product.ProductId = Guid.NewGuid().ToString();
            product.Name = body.Name;
            product.Description = body.Description;
            product.OriginalPrice = body.OriginalPrice;
            product.RetailPrice = body.RetailPrice;
            product.Quantity = body.Quantity;
            product.ImageUrl = body.ImageUrl;
            product.CategoryId = body.CategoryId;
            product.ShopId = "U1";
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
             var product = this.ProductRepository.GetProductById(body.ProductName);
            if(body.ProductName != null)
            {
                product.Name = body.ProductName;
            }
            if(body.ProductDescription != null)
            {
                product.Description = body.ProductDescription;
            }
            if(body.OriginalPrice != null)
            {
                product.OriginalPrice = body.OriginalPrice;
            }
            if(body.RetailPrice != null)
            {
                product.RetailPrice = body.RetailPrice;
            }
            if(body.Quantity != null)
            {
                product.Quantity = body.Quantity;
            }
            if(body.ImageUrl != null)
            {
                product.ImageUrl = body.ImageUrl;
            }
            if(body.CategoryId != null)
            {
                product.CategoryId = body.CategoryId;  
            }
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
