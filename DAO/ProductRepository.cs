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

        public List<Product> GetAllProduct()
        {
            List<Product> listProducts = this.DBContext.Set<Product>().ToList<Product>();
            return listProducts;
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
    }
}
