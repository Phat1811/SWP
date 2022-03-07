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
        public (List<Product>, int) GetProducts(int pageIndex, int pageSize, double min, double max, string name, string categoryId, CategoryStatus categoryStatus)
        {
            List<Product> products = null;
            if (categoryStatus == CategoryStatus.ACTIVE)
            {
                products = this.DBContext.Product.Where(item => item.RetailPrice >= min && item.RetailPrice <= max && item.Name.Contains(name) && item.CategoryId.Contains(categoryId) && item.Category.Status == CategoryStatus.ACTIVE).ToList();
            }
            else
            {
                products = this.DBContext.Product.Where(item => item.RetailPrice >= min && item.RetailPrice <= max && item.Name.Contains(name) && item.CategoryId.Contains(categoryId)).ToList();
            }
            foreach (Product product in products)
            {
                if (product != null)
                {
                    this.DBContext.Entry(product).Reference(item => item.Category).Load();
                }
            }

            var pagelist = (List<Product>)products.Take((pageIndex + 1) * pageSize).Skip(pageIndex * pageSize).ToList();
            return (pagelist, products.Count);
        }

        public List<Product> GetListProductByCategoryId(string categoryId)
        {
            List<Product> list = this.DBContext.Product.Where(item => item.CategoryId == categoryId).ToList();
            return list;
        }
    }
}
