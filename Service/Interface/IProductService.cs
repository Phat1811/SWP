using MedicalStore.Models;
using System.Collections.Generic;
namespace MedicalStore.Service.Interface
{
    public interface IProductService
    {
        public Product GetProductById(string productId);
        public bool CreateProductHandler(Product product);
        public bool UpdateProductHandler(Product product);
        public bool DeleteProductHandler(Product product);
        public List<Product> GetProducts();
        public List<Product> GetListProductByShopId(string shopId);
    }
}
