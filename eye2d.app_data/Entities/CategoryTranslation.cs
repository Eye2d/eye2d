﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class CategoryTranslation
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
<<<<<<< HEAD
        public string SeoAlias { set; get; }
        public string LanguageId { set; get; }
        public Category Category { get; set; }
        public Language Language { get; set; }


=======
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }
        public Category Category { get; set; }
        public Language Language { get; set; }
>>>>>>> Feature/database_design
    }
}
