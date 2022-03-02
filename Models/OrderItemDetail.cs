using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class OrderItemDetail
    {
        public Product Product { set; get; }
        public string ShopName { set; get; }
        public int Quantity { set; get; }
        public float SalePrice { set; get; }

    }
}
