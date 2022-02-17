using MedicalStore.Models;

namespace MedicalStore.DAO.Interface
{
    public interface IProductRepository
    {
        public Product GetProductByName(string name);
        public Product GetProductById(string id);
        public bool InsertHandler(Product product);
        public bool UpdateHandler(Product product);
        public bool DeleteHandler(Product product);

    }
}
