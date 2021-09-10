using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int? ProductId { set; get; }
        public int Quantity { set; get; }
        public float Price { set; get; }
        public Product Product { get; set; }
    }

}
