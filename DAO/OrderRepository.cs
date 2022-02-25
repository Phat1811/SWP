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
        private readonly IOrderItemRepository OrderItemRepository;
        public OrderRepository(DBContext dBContext, IOrderItemRepository OrderItemRepository)
        {
            this.DBContext = dBContext;
            this.OrderItemRepository = OrderItemRepository;
        }

        public List<Order> GetAllActiveOrder()
        {
            List<Order> list = this.DBContext.Order.Where<Order>(item => item.Status == OrderStatus.ACTIVE).ToList<Order>();
            return list;
        }

        public List<Order> GetAllOrder()
        {
            List<Order> listOrder = this.DBContext.Set<Order>().ToList<Order>();
            return listOrder;
        }

        public List<Order> GetAllSoldOrder(string sellerId)
        {
            List<Product> listProduct = OrderItemRepository.getAllProductBySellerId(sellerId).ToList<Product>();
            List<OrderItem> listOrderItem = new List<OrderItem>();
            foreach(Product p in listProduct)
            {
                List<OrderItem> listOrderItemByProduct = OrderItemRepository.GetAllOrderItemByProductId(p.ProductId).ToList<OrderItem>();
                listOrderItem.AddRange(listOrderItemByProduct);
            }
            List<Order> listOrder = new List<Order>();
            foreach(OrderItem oi in listOrderItem)
            {
                List<Order> listOrderByOrderItem = this.DBContext.Order.Where<Order>(item => item.OrderId == oi.OrderId).ToList<Order>();
                foreach(Order order in listOrderByOrderItem)
                {
                    bool checkExistOrder = listOrder.Any(item => item.OrderId == order.OrderId);
                    if(checkExistOrder != true)
                    {
                        listOrder.Add(order);
                    }
                }
            }
            return listOrder;
        }

        public Order GetOrderByOrderId(string orderId)
        {
            Order order = this.DBContext.Order.FirstOrDefault(item => item.OrderId == orderId);
            return order;
        }

        public List<Order> GetUserOrderHistory(string customerId)
        {
            List<Order> list = this.DBContext.Order.Where<Order>(item => item.CustomerId == customerId).ToList<Order>();
            return list;
        }
    }
}
