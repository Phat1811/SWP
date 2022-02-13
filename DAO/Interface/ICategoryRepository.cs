using MedicalStore.Models;

namespace MedicalStore.DAO.Interface
{
    public interface ICategoryRepository
    {
        public Category GetCategoryByID(string categoryId);
        public Category GetCategortByName(string categoryName);
        public bool CreateCategoryHandler(Category category);
        public bool UpdateCategoryInfoHandler(Category Category);
        public bool DeleteCategoryHandler(Category Category);
    }
}
