using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;

namespace MedicalStore.DAO
{
    public class CategoryService : ICategoryService
    {
        private readonly DBContext DBContext;
        private readonly ICategoryRepository CategoryRepository;
        public CategoryService(DBContext dBContext, ICategoryRepository categoryRepository)
        {
            this.DBContext = dBContext;
            this.CategoryRepository = categoryRepository;
        }
        public bool CreateCategoryHandler(Category category)
        {
            return this.CategoryRepository.CreateCategoryHandler(category);
        }

        public bool DeleteCategoryHandler(Category category)
        {
            return this.CategoryRepository.DeleteCategoryHandler(category);
        }

        public bool UpdateCategoryInfoHandler(Category category)
        {
            return this.CategoryRepository.UpdateCategoryInfoHandler(category);
        }
    }
}
