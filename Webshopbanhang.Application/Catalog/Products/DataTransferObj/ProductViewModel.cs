﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshopbanhang.Application.Catalog.Products.DataTransferObj
{
   public class ProductViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OrigingalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { set; get; }
        public object OriginalPrice { get; internal set; }
    }
}
