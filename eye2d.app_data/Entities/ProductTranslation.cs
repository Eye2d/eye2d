using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class ProductTranslation
    {
        public int Id { set; get; }
        public Product ProductId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public Guid languageId { set; get; }

    }
}
