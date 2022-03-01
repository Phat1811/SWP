using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class OrderItemDetail
    {
        public string ProductName { set; get; }
        public string ShopName { set; get; }
        public float RetailPrice { set; get; }
        public string ProductImageUrl { set; get; }
        public int Quantity { set; get; }
        public float SalePrice { set; get; }

    }
}
