using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContext DBContext;

        public ProductRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }

        public bool DeleteHandler(Product product)
        {
            this.DBContext.Product.Update(product);
            return this.DBContext.SaveChanges() > 0;
        }

        public Product GetProductById(string id)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.ProductId == id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.Name == name);
            return product;
        }

        public bool InsertHandler(Product product)
        {
            this.DBContext.Product.Add(product);
            return this.DBContext.SaveChanges() > 0;
        }

        public bool UpdateHandler(Product product)
        {
            this.DBContext.Product.Update(product);
            this.DBContext.SaveChanges();
            return true;
        }

        public (List<Product>, int) GetListProductByShopId(string shopId, int pageIndex, int pageSize)
        {
            List<Product> products = this.DBContext.Product.Where(item => item.ShopId == shopId).ToList();
            var result = products.Take((pageIndex + 1) * pageSize).Skip(pageIndex * pageSize).ToList();
            return (result, products.Count);
        }
        public List<Product> GetAllProduct()
        {
            List<Product> products = this.DBContext.Product.ToList();
            return products;
        }
    }
}
