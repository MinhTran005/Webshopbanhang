using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshopbanhang.data.Entities;
using Webshopbanhang.data.Enums;

namespace Webshopbanhang.data.Extensions
{
   public static class ModelBuilderExtension
    {
        public static void Seed (this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key="HomeTitle",Value="this is home page"},
                new AppConfig() { Key = "HomeKeyword", Value = "this is Keywor" },
                new AppConfig() { Key = "HomeDesciption", Value = "this is home page" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id="vi-VN",Name="Tiếng Viet",IsDefault=true},
                new Language() { Id="en-US",Name="English",IsDefault=false}
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() {Id=1, IsShowOnHome=true,ParenID=null,SortOrder=1,Status=Status.Active,
                    
                },
                new Category()
                {
                    Id=2,
                    IsShowOnHome = true,
                    ParenID = null,
                    SortOrder = 2,
                    Status = Status.Active,
                    
                }
            );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                
                        new CategoryTranslation(){Id=1, CategoryId=1,Name="Súp lơ",LanguageId="vi-VN",SeoAlias="sup-lo",SeoDescription="Sản phẩm rau sạch tự nhiên",SeoTitle="Sản phẩm rau sạch tự nhiên"},
                        new CategoryTranslation(){Id=2, CategoryId = 1, Name ="Cauliflower",LanguageId="en-US",SeoAlias="cauliflower",SeoDescription="Natural clean vegetable products",SeoTitle="Natural clean vegetable products"},
                        new CategoryTranslation() {Id=3,CategoryId=2 ,Name = "Bắp cải", LanguageId = "vi-VN", SeoAlias = "bap-cai", SeoDescription = "Sản phẩm Bắp cải sạch tự nhiên", SeoTitle = "Sản phẩm Bắp cải sạch tự nhiên" },
                        new CategoryTranslation() {Id=4,CategoryId=2, Name = "Cabbage", LanguageId = "en-US", SeoAlias = "cabbage", SeoDescription = "Natural clean cabbage products", SeoTitle = "Natural clean cabbage products" }
                    );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,
                    DateCreated=DateTime.Now,OrigingalPrice=100000,Price=200000,Stock=0,ViewCount=0,        
                 
                   
                }
            );
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id=1,
                     ProductId=1,
                     Name = "Súp lơ sạch Đà Lạt",
                     LanguageId = "vi-VN",
                     SeoAlias = "sup-lo-sach",
                     SeoDescription = "Súp lơ sạch Đà Lạ",
                     SeoTitle = "SSúp lơ sạch Đà Lạ",
                     Details = "Súp lơ sạch Đà Lạ",
                     Description = ""
                 },
                        new ProductTranslation()
                        {

                            Id=2,
                            ProductId = 1,
                            Name = "Cauliflower In Đà Lạt",
                            LanguageId = "en-US",
                            SeoAlias = "cauliflower-dalat",
                            SeoDescription = "Natural clean vegetable products In Đà Lạt",
                            SeoTitle = "Natural clean vegetable products In Đà Lạt",
                            Details = "Description of product",
                            Description = ""
                        }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() {ProductId=1, CategoryId = 1 }
                );
        }
    }
}
