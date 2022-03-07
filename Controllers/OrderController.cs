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

        [HttpGet("sold")]
        [RoleGuardAttribute("2")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult SoldOrder(int pageIndex = 0, int pageSize = 12)
        {
            var user = (User)this.ViewData["user"];
            List<Order> listOrder = OrderService.GetlistSoldOrder(user.UserId);
            listOrder.Sort((x, y) => y.CreateDate.CompareTo(x.CreateDate));
            this.ViewData["listSoldOrder"] = listOrder;
            return View(Routers.SoldOrder.Page);
        }

        [HttpGet("detail")]
        [ServiceFilter(typeof(AuthGuard))]
        public IActionResult OrderDetail(string orderId, int pageIndex = 0, int pageSize = 1000)
        {
            var (items, count) = this.OrderService.GetOrderDetail(orderId, pageIndex, pageSize);
            Order order = this.OrderService.GetOrderByOrderId(orderId);
            List<Product> listProduct = new List<Product>();
            List<string> listShopName = new List<string>();
            foreach(OrderItem oi in items)
            {
                Product p = ProductService.GetProductById(oi.ProductId);
                listProduct.Add(p);
                listShopName.Add(UserService.GetUserById(p.ShopId).Name);
            }
            this.ViewData["listProduct"] = listProduct;
            this.ViewData["listShopName"] = listShopName;
            this.ViewData["listOrderItem"] = items;
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
