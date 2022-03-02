using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IProductRepository
    {
        public Product GetProductByName(string name);
        public Product GetProductById(string id);
        public bool InsertHandler(Product product);
        public bool UpdateHandler(Product product);
        public bool DeleteHandler(Product product);
        public (List<Product>, int) GetListProductByShopId(string shopId, int pageIndex, int pageSize);
        public List<Product> GetAllProduct();
    }
}
