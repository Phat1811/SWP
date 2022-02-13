using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using System.Collections.Generic;
using System.Linq;

namespace MedicalStore.DAO
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DBContext DBContext;
        public OrderRepository(DBContext dBContext)
        {
            this.DBContext = dBContext;
        }
        public List<Order> GetAllOrder()
        {
            return DBContext.Set<Order>().ToList<Order>();
        }
    }
}
