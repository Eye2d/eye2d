using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Application.Softwares.Dtos
{
    public class SoftwareEditRequest
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
}
