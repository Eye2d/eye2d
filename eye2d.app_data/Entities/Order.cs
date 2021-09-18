using eye2d.app_data.Enum;
using eye2d.app_data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid Userid { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
