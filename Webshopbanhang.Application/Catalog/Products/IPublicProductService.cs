using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.Application.Catalog.Products.DataTransferObj;
using Webshopbanhang.Application.Dtos;

namespace Webshopbanhang.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId,int pageIndex,int pageSize);
    }
}
