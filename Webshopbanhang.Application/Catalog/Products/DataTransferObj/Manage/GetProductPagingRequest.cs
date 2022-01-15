using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.Application.Dtos;

namespace Webshopbanhang.Application.Catalog.Products.DataTransferObj.Manage
{
   public class GetProductPagingRequest :PagingRequestBase
    {
       public string Keyword { get; set; } 
       public List<int> CategoryIds { get; set; }
    }
}
