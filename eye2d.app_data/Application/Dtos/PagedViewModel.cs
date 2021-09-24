using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Application.Dtos
{
    public class PagedViewModel<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
