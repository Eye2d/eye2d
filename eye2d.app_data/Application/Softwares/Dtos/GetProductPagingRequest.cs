using eye2d.app_data.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Application.Softwares.Dtos
{
    class GetProductPagingRequest : PagingRequestBase

    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
