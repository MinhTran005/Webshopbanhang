using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Webshopbanhang.data.EF
{
    public class WebshopDbContextFactory : IDesignTimeDbContextFactory<WebshopDbContext>
    {
        public WebshopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WebshopbanhangDb");
            var optionsBuilder = new DbContextOptionsBuilder<WebshopDbContext>();

            optionsBuilder.UseSqlServer(connectionString);
            return new WebshopDbContext(optionsBuilder.Options);


        }
    }
}
