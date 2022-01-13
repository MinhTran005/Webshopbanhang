using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.data.Entities;

namespace Webshopbanhang.data.Configruations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OrigingalPrice).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
           
        }
    }
}
