using eye2d.app_data.Application.Dtos;
using eye2d.app_data.Application.Softwares.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Application.Softwares
{
    public interface IPublicSoftwareService
    {
        PagedViewModel<SoftwareViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
