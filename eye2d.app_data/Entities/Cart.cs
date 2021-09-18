using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Cart
    {
        public int id { set; get; }
        public object Id { get; internal set; }
        public int? ProductId { set; get; }
        public int Quantity { set; get; }
        public float Price { set; get; }
    }

}
