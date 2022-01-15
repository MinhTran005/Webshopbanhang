using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.Application.Catalog.Products.DataTransferObj;
using Webshopbanhang.Application.Dtos;
using Webshopbanhang.data.EF;
using Webshopbanhang.data.Entities;

namespace Webshopbanhang.Application.Catalog.Products
{
   public class ManageProductService : IManageProductService
    {
        private readonly WebshopDbContext _context;
        public ManageProductService(WebshopDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
           return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task< List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task< PageViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
