using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class OrderDetail
    {
        public Order OrderId { set; get; }
        public Product ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        

    }
}
