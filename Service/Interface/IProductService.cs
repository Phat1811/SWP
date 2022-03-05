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
        public (List<Product>, int) GetListProductByShopId(string shopId, int pageIndex, int pageSize);
        public (List<Product>, int) GetProducts(int pageIndex, int pageSize, double min, double max, string name, string categoryId, CategoryStatus categoryStatus);

    }
}
