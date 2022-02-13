using MedicalStore.Models;

namespace MedicalStore.DAO.Interface
{
    public interface ICategoryService
    {
        public bool CreateCategoryHandler(Category category);
        public bool UpdateCategoryInfoHandler(Category category);
        public bool DeleteCategoryHandler(Category category);
    }
}
