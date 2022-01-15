using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.Application.Catalog.Products.DataTransferObj;
using Webshopbanhang.Application.Catalog.Products.DataTransferObj.Public;
using Webshopbanhang.Application.Dtos;

namespace Webshopbanhang.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
