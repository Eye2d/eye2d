using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class CategoryTranslation
    {
        public int Id { set; get; }
        public Category CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public Guid LanguageId { set; get; }
        public string SeoAlias { set; get; }

    }
}
