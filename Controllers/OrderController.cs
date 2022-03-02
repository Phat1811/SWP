using Microsoft.AspNetCore.Mvc;
using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Utils.Common;
using MedicalStore.Service.Interface;
using MedicalStore.Auth;
using System;
using System.Collections.Generic;

namespace MedicalStore.Controllers
{
    [Route("order")]
    [ServiceFilter(typeof(AuthGuard))]
    public class OrderController : Controller
    {
        private readonly IOrderService OrderService;
        private const string CartSession = "CartSession";
        private readonly ICartService CartService;
        private readonly IProductService ProductService;
        private readonly IUserService UserService;
        public OrderController(IOrderService orderService, ICartService cartService, IProductService productService, IUserService userService)
        {
            this.OrderService = orderService;
            this.CartService = cartService;
            this.ProductService = productService;
            this.UserService = userService;
        }

        [HttpGet("")]
        [RoleGuardAttribute("1")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult Order(int pageIndex = 0, int pageSize = 12)
        {
            var user = (User)this.ViewData["user"];
            var (orders, total) = this.OrderService.GetOrders(user.UserId, pageIndex, pageSize);
            orders.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            this.ViewData["orders"] = orders;
            this.ViewData["total"] = total;
            return View(Routers.Order.Page);
        }

        [HttpGet("detail")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult OrderDetail(string orderId, int pageIndex = 0, int pageSize = 1000)
        {
            List<OrderItemDetail> orderItemDetails = new List<OrderItemDetail>(); 
            var (items, count) = this.OrderService.GetOrderDetail(orderId, pageIndex, pageSize);
            foreach(OrderItem oi in items)
            {
                var oit = new OrderItemDetail();
                oit.Quantity = oi.Quantity;
                oit.SalePrice = oi.SalePrice;
                oit.ShopName = UserService.GetUserById(ProductService.GetProductById(oi.ProductId).ShopId).Name;
                oit.Product = ProductService.GetProductById(oi.ProductId);
                orderItemDetails.Add(oit);
            }
            Order order = this.OrderService.GetOrderByOrderId(orderId);
            this.ViewData["listOrderDetail"] = orderItemDetails;
            this.ViewData["total"] = count;
            this.ViewData["order"] = order;
            this.ViewData["customerName"] = this.UserService.GetUserById(order.CustomerId).Name;
            return View(Routers.OrderDetail.Page);
        }


        [HttpGet("manager")]
        [RoleGuardAttribute("2")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult GetAllOrders(string startDate, string endDate, string search, int pageIndex = 0, int pageSize = 12)
        {
            var now = DateTime.Now;
            string lastDate = now.AddDays(1).ToString("yyyy-MM-dd");
            string firstDate = now.AddYears(-1).ToString("yyyy-MM-dd");

            if (startDate == null || endDate == null)
            {
                var query = $"?startDate={firstDate}&endDate={lastDate}&search=";
                return Redirect(Routers.OrderManager.Link + query);
            }

            try
            {
                var (orders, total) = this.OrderService.SearchOrders(startDate, endDate, search, pageIndex, pageSize);
                this.ViewData["orders"] = orders;
                this.ViewData["total"] = total;
                return View(Routers.OrderManager.Page);
            }
            catch (System.Exception)
            {

                var query = $"?startDate={firstDate}&endDate={lastDate}&search=";
                return Redirect(Routers.OrderManager.Link + query);
            }
        }
    }
}
