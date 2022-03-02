using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface ICategoryService
    {
        public bool CreateCategoryHandler(Category category);
        public bool UpdateCategoryInfoHandler(Category category);
        public bool DeleteCategoryHandler(Category category);
        public (List<Category>, int) GetAllCategories(int pageIndex, int pageSize);

    }
}
