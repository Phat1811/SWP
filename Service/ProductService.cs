using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils;
using System.Collections.Generic;
using MedicalStore.Utils.Interface;

namespace MedicalStore.Service
{
    public class ProductService : IProductService
    {
        private readonly DBContext DBContext;
        private readonly IProductRepository ProductRepository;

        public ProductService(DBContext dBContext, IProductRepository productRepository)
        {
            this.DBContext = dBContext;
            ProductRepository = productRepository;
        }
        public Product GetProductById(string productId)
        {
            return this.ProductRepository.GetProductById(productId);
        }


        public bool CreateProductHandler(Product product)
        {
            return this.ProductRepository.InsertHandler(product);
        }

        public bool DeleteProductHandler(Product product)
        {
            return this.ProductRepository.DeleteHandler(product);
        }

        public bool UpdateProductHandler(Product product)
        {
            return this.ProductRepository.UpdateHandler(product);
        }

        public List<Product> GetProducts()
        {
            return this.ProductRepository.GetAllProduct();
        }

        public List<Product> GetListProductByShopId(string shopId)
        {
            return this.ProductRepository.GetListProductByShopId(shopId);
        }
    }
}
