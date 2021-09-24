using eye2d.app_data.Application.Dtos;
using eye2d.app_data.Application.Softwares.Dtos;
using eye2d.app_data.Entities;
using eye2d.app_data.Entity_framwork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eye2d.app_data.Application.Softwares
{
    class ManageSoftwareService : IManageSoftwareService
    {
        private readonly Eye2d_DBcontext _context;
        public ManageSoftwareService(Eye2d_DBcontext context)
        {
            _context = context;
        
        }
        public async Task<int> Create(SoftwareCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync()
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SoftwareViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<SoftwareViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(SoftwareEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
