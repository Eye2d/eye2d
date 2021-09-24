using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Cart
    {
<<<<<<< HEAD
        public int id { set; get; }
        public int? ProductId { set; get; }
        public int Quantity { set; get; }
        public float Price { set; get; }
        public Guid UserId { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
        public AppUser AppUser { get; set; }
=======
        public int Id { set; get; }
        public int? ProductId { set; get; }
        public int Quantity { set; get; }
        public float Price { set; get; }
        public Product Product { get; set; }
>>>>>>> Feature/database_design
    }

}
