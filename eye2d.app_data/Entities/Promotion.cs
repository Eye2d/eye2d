using eye2d.app_data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
   public class Promotion
    {
        public int Id { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public bool ApplyForAll { set; get; }
        public decimal DiscountPercent { set; get; }
        public decimal DiscountAmount { set; get; }
        public Product ProductIds { set; get; }
        public int ProductCategoryIds { set; get; }
        public PromotionStatus Status { set; get; }

    }
}
