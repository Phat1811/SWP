using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IOrderRepository
    {
        public List<Order> GetAllOrder();
        public List<Order> GetAllActiveOrder();
        public List<Order> GetAllSoldOrder(string sellerId);
        public List<Order> GetUserOrderHistory(string customerId);
        public Order GetOrderByOrderId(string orderId);

    }
}
