using MedicalStore.Models;

namespace MedicalStore.Service.Interface
{
    public interface IProductService
    {
        public bool CreateProductHandler(Product product);
        public bool UpdateProductHandler(Product product);
        public bool DeleteProductHandler(Product product);
    }
}
