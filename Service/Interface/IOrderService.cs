﻿using System.Collections.Generic;
using MedicalStore.Models;

namespace MedicalStore.Service.Interface
{
    public interface IOrderService
    {
        public (List<Order>, int) GetOrders(string userId, int pageIndex, int pageSize);
        public (List<OrderItem>, int) GetOrderDetail(string orderId, int pageIndex, int pageSize);
        public (List<Order>, int) GetAllOrders(int pageIndex, int pageSize);
        public (List<Order>, int) SearchOrders(string startDate, string endDate, string search, int pageIndex, int pageSize);
        public bool CreateOrderHandler(Order order);
        public bool CreateOrderItemHandler(OrderItem orderItem);
        public Order GetOrderByOrderId(string orderId);
        public List<Order> GetlistSoldOrder(string shopId);
    }
}
