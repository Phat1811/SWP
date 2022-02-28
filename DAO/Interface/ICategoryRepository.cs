using MedicalStore.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public List<Category> GetAllCategories();
        public List<SelectListItem> GetListCategoriesByStatus(CategoryStatus categoryStatus);
    }
}
