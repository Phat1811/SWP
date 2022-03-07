﻿using MedicalStore.Models;
using System.Collections.Generic;

namespace MedicalStore.DAO.Interface
{
    public interface IOrderItemService
    {
        public List<OrderItem> GetAllOrderItemByOrderId(string orderId);
        public List<OrderItem> GetAllOrderItemByProductId(string productId);
    }
}
