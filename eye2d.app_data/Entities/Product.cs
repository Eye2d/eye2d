﻿using System;
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
        public int ViewCount { set; get; }
<<<<<<< HEAD

=======
>>>>>>> Feature/database_design
        public DateTime DateCreated { set; get; }
        public DateTime DateUpdate { set; get; }
        public String SeoAlias { set; get; }
        public List<ProductInCategory> ProductInCategory { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
<<<<<<< HEAD
        public List<ProductTranslation> ProductTranslations { get; set; }
=======
        public List <ProductTranslation> ProductTranslations { get; set; }
>>>>>>> Feature/database_design


    }
}
