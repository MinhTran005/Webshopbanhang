using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.Application.Dtos;

namespace Webshopbanhang.Application.Catalog.Products.DataTransferObj.Public
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
