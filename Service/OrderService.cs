using MedicalStore.DAO.Interface;
using MedicalStore.Service.Interface;
using MedicalStore.Models;
using MedicalStore.Utils;
using MedicalStore.Utils.Interface;
using System.Collections.Generic;

namespace MedicalStore.DAO
{
    public class OrderService : IOrderService
    {
        private readonly DBContext DBContext;
        private readonly IOrderRepository OrderRepository;
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        private readonly IOrderItemService OrderItemService;
        public OrderService(IProductService productService, ICartService cartService, DBContext dBContext, IOrderRepository orderRepository, IOrderItemService orderItemService)
        {
            this.DBContext = dBContext;
            this.OrderRepository = orderRepository;
            this.CartService = cartService;
            this.ProductService = productService;
            this.OrderItemService = orderItemService;
        }

        public (List<Order>, int) GetOrders(string userId, int pageIndex, int pageSize)
        {
            return this.OrderRepository.GetOrders(userId, pageIndex, pageSize);
        }
        public (List<OrderItem>, int) GetOrderDetail(string orderId, int pageIndex, int pageSize)
        {
            return this.OrderRepository.GetOrderDetail(orderId, pageIndex, pageSize);
        }
        public (List<Order>, int) GetAllOrders(int pageIndex, int pageSize)
        {
            return this.OrderRepository.GetAllOrders(pageIndex, pageSize);
        }
        public (List<Order>, int) SearchOrders(string startDate, string endDate, string search, int pageIndex, int pageSize)
        {
            return this.OrderRepository.SearchOrders(startDate, endDate, search, pageIndex, pageSize);
        }

        public bool CreateOrderHandler(Order order)
        {
            return this.OrderRepository.CreateOrderHandler(order);
        }

        public bool CreateOrderItemHandler(OrderItem orderItem)
        {
            return this.OrderRepository.CreateOrderItemHandler(orderItem);
        }

        public Order GetOrderByOrderId(string orderId)
        {
            return this.OrderRepository.GetOrderByOrderId(orderId);
        }

        public List<Order> GetlistSoldOrder(string shopId)
        {
            List<OrderItem> listOrderItem = new List<OrderItem>();
            List<Order> listOrder = new List<Order>();
            var(listProduct, total)  = this.ProductService.GetListProductByShopId(shopId, 0, 12);
            foreach(Product p in listProduct)
            {
                List<OrderItem> items = this.OrderItemService.GetAllOrderItemByProductId(p.ProductId);
                listOrderItem.AddRange(items);
            }
            foreach(OrderItem oi in listOrderItem)
            {
                Order order = this.GetOrderByOrderId(oi.OrderId);
                if (!(listOrder.Contains(order))){
                    listOrder.Add(order);
                }
            }

            return listOrder;
        }

        public float CalculateProfitHandler(string shopId)
        {
            var (listProducts, t) = this.ProductService.GetListProductByShopId(shopId, 0, 12);
            float profit = 0;
            foreach (Product p in listProducts)
            {
                List<OrderItem> orderItems = this.OrderItemService.GetAllOrderItemByProductId(p.ProductId);                
                foreach (OrderItem oi in orderItems)
                {
                    Order order = this.OrderRepository.GetOrderByOrderId(oi.OrderId);
                    if(order.Status != OrderStatus.INACTIVE) { 
                    profit += (p.RetailPrice - p.OriginalPrice) * oi.Quantity;
                    }
                }
            }
            return profit;
        }
    }
}
