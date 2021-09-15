using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Product
    {
        public int Id { set; get; }
       public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int Viewcount { set; get; }
        public object ViewCount { get; internal set; }
        public DateTime DateCreated { set; get; }
        public DateTime DateUpdate { set; get; }
        public String SeoAlias { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Product Product { get; set; }


    }
}
