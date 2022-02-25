using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;

namespace MedicalStore.DAO
{
    public class OrderItemService : IOrderItemService
    {
        private readonly DBContext DBContext;
        private readonly IOrderItemRepository OrderItemRepository;
        
    }
}
