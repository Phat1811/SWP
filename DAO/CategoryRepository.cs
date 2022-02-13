using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContext DBContext;
        public CategoryRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }
        public bool CreateCategoryHandler(Category category)
        {
            this.DBContext.Category.Add(category);
            return this.DBContext.SaveChanges() > 0;
        }

        public bool DeleteCategoryHandler(Category category)
        {
            this.DBContext.Category.Update(category);
            return this.DBContext.SaveChanges() > 0;
        }

        public Category GetCategortByName(string categoryName)
        {
            Category category = this.DBContext.Category.FirstOrDefault(item => item.Name == categoryName);
            return category;
        }

        public Category GetCategoryByID(string categoryId)
        {
            Category category = this.DBContext.Category.FirstOrDefault(item => item.CategoryId == categoryId);
            return category;
        }

        public List<Product> GetProductByCategoryID(string categoryID)
        {
            List<Product> list = this.DBContext.Product.Where<Product>(item => item.CategoryId == categoryID).ToList<Product>();
            return list;
        }

        public bool DisableProductByID(string productID)
        {
            Product product = this.DBContext.Product.FirstOrDefault(item => item.ProductId == productID);
            product.Status = ProductStatus.INACTIVE;
            this.DBContext.Product.Update(product);
            return this.DBContext.SaveChanges() > 0;
        }

        public bool UpdateCategoryInfoHandler(Category category)
        {
            this.DBContext.Category.Update(category);
            return this.DBContext.SaveChanges() > 0;
        }
    }
}
