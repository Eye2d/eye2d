using eye2d.app_data.Application.Dtos;
using eye2d.app_data.Application.Softwares.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eye2d.app_data.Application.Softwares
{
    public interface IManageSoftwareService
    {
        Task<int> Create(SoftwareCreateRequest request);
        Task<int> Update(SoftwareEditRequest request);
        Task<int> Delete(int productId);
        Task<List<SoftwareViewModel>> GetAll();
        Task<PagedViewModel<SoftwareViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize);

    }
}
