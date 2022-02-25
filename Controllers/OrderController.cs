using Microsoft.AspNetCore.Mvc;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using System.Collections.Generic;
using MedicalStore.Controllers.DTO;
using System.Linq;
using MedicalStore.Auth;

namespace MedicalStore.Controllers
{
    [Route("order")]
    [ServiceFilter(typeof(AuthGuard))]
    public class OrderController : Controller
    {
        private readonly IOrderRepository OrderRepository;
        private readonly IOrderItemRepository OrderItemRepository;
        private readonly IProductRepository ProductRepository;
        private readonly IUserRepository UserRepository;

        public OrderController(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IProductRepository productRepository, IUserRepository UserRepository)
        {
            this.OrderRepository = orderRepository;
            this.OrderItemRepository = orderItemRepository;
            this.ProductRepository = productRepository;
            this.UserRepository = UserRepository;
        }

        [HttpGet("")]
        public IActionResult GetAllUserOrder(string sortBy)
        {
            var user = (User)this.ViewData["user"];
            if (user == null)
            {
                return Redirect(Routers.Login.Link);
            }
            List<Order> listOrder = new List<Order>();
            if (user.RoleId == "1") 
            {
                List<Order> listOrder1 = OrderRepository.GetUserOrderHistory(user.UserId);
                listOrder = listOrder1;
            }
            if(user.RoleId == "2")
            {
                List<Order> listOrder2 = OrderRepository.GetAllSoldOrder(user.UserId);
                listOrder = listOrder2;
            }

            listOrder.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            if (sortBy == "priceIncreasing")
            {
                listOrder.Sort((x, y) => x.Total.CompareTo(y.Total));
            }
            if (sortBy == "priceDescending")
            {
                listOrder.Sort((x, y) => y.Total.CompareTo(x.Total));
            }
            if (sortBy == "createDateIncreasing")
            {
                listOrder.Sort((x, y) => x.CreateDate.CompareTo(y.CreateDate));
            }
            if (sortBy == "createDateDescending")
            {
                listOrder.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            }
            this.ViewData["listOrder"] = listOrder;
            return View(Routers.Order.Page);
        }
        
        [HttpGet("manager")]
        public IActionResult GetAllOrder(string sortBy)
        {
            User user = (User)this.ViewData["user"];
            if (user == null)
            {
                return Redirect(Routers.Login.Link);
            }
            List<Order> listOrder = OrderRepository.GetAllOrder();
            listOrder.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            if (sortBy == "priceIncreasing")
            {
                listOrder.Sort((x, y) => x.Total.CompareTo(y.Total));
            }
            if (sortBy == "priceDescending")
            {
                listOrder.Sort((x, y) => y.Total.CompareTo(x.Total));
            }
            if (sortBy == "createDateIncreasing")
            {
                listOrder.Sort((x, y) => x.CreateDate.CompareTo(y.CreateDate));
            }
            if (sortBy == "createDateDescending")
            {
                listOrder.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            }
            this.ViewData["listOrder"] = listOrder;
            return View(Routers.OrderManager.Page);
        }

        [HttpGet("detail")]
        public IActionResult GetOrderDetail(string orderId)
        {
            var order = OrderRepository.GetOrderByOrderId(orderId);
            this.ViewData["order"] = order;
            List<OrderItem> listOrderItem = OrderItemRepository.GetAllOrderItemByOrderId(orderId);
            List<OrderItemDetail> listOrderItemDetail = new List<OrderItemDetail>();
            foreach (OrderItem oi in listOrderItem)
            {
                OrderItemDetail oid = new OrderItemDetail();
                Product p = ProductRepository.GetProductById(oi.ProductId);
                oid.ProductName = p.Name;
                oid.ProductImageUrl = p.ImageUrl;
                oid.RetailPrice = p.RetailPrice;
                oid.ShopName = UserRepository.GetUserById(p.ShopId).Name;
                oid.SalePrice = oi.SalePrice;
                oid.Quantity = oi.Quantity;
                listOrderItemDetail.Add(oid);
            }
            string customerName = UserRepository.GetUserById(order.CustomerId).Name.ToString();
            this.ViewData["customerName"] = customerName;
            this.ViewData["listOrderItemDetail"] = listOrderItemDetail;
            return View(Routers.OrderDetail.Page);
        }
    }
}
