using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface ICategoryRepository
    {
        public Category GetCategoryByID(string categoryId);
        public Category GetCategortByName(string categoryName);
        public List<Product> GetProductByCategoryID(string categoryID);
        public bool DisableProductByID(string productID);

        public bool CreateCategoryHandler(Category category);
        public bool UpdateCategoryInfoHandler(Category Category);
        public bool DeleteCategoryHandler(Category Category);
    }
}
