using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Language
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public bool IsDefault { set; get; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
