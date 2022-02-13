using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IOrderRepository
    {
        public List<Order> GetAllOrder(); 
    }
}
