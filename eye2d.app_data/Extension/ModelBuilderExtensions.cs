using eye2d.app_data.Entities;
using eye2d.app_data.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is a testing database model" },
                new AppConfig() { Key = "HomeKeyWords", Value = "This is a testing keywords database model" },
                new AppConfig() { Key = "HomeDesciption", Value = "This is a testing description database model" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id="en-EN", Name="English", IsDefault=true},
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = false }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShownOnHome = true, 
                    ParentId = null, 
                    SortOrder = 1, 
                    Status = Status.Active, 
                    
                },
                
                new Category()
                {
                    Id = 2,
                    IsShownOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Online Photoshop design applications",
                    LanguageId = "en-EN",
                    SeoAlias = "Photoshop, Illustrator",
                    SeoDescription = "All-in-one online Photoshop design platform",
                    SeoTitle = "All-in-one online Photoshop design platform" },
                new CategoryTranslation() {
                    Id=2,
                    CategoryId = 1,
                    Name = "Ứng dụng thiết kế online Photoshop, Illustor",
                    LanguageId = "vi-VN",
                    SeoAlias = "Autocad, Photoshop, Illustrator, 3D Max",
                    SeoDescription = "All-in-one online design platform",
                    SeoTitle = "Nền tảng thiết kế trực tuyến All-in-one "
                },
                new CategoryTranslation() {
                    Id =3,
                    CategoryId = 2,
                    Name = "Online Autocad design applications",
                    LanguageId = "en-EN",
                    SeoAlias = "Autocad, 3ds Max",
                    SeoDescription = "All-in-one online Autocad design platform",
                    SeoTitle = "All-in-one online Autocad design platform" },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Ứng dụng thiết kế online Autocad, Photoshop, illustor, 3D Max",
                    LanguageId = "vi-VN",
                    SeoAlias = "Autocad, Photoshop, Illustrator, 3D Max",
                    SeoDescription = "All-in-one online design platform",
                    SeoTitle = "Nền tảng thiết kế trực tuyến All-in-one "
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 30000,
                    Price = 100000,
                    Stock = 0,
                    ViewCount = 0,
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() {
                    Id = 1,
                    ProductId = 1,
                    Name = "Photoshop all apps",
                    LanguageId = "en-EN",
                    SeoAlias = "Acrobat Pro, Photoshop, Illustrator, InDesign, Premiere Pro, After Effects, Lightroom, XD, Animate, LIghtroom Classic, Dreamweaver",
                    SeoDescription = "Acrobat Pro, Photoshop, Illustrator, InDesign, Premiere Pro, After Effects, Lightroom, XD, Animate, LIghtroom Classic, Dreamweaver",
                    SeoTitle = "Acrobat Pro, Photoshop, Illustrator, InDesign, Premiere Pro, After Effects, Lightroom, XD, Animate, LIghtroom Classic, Dreamweaver",
                    Details = "All-in-One online design Platform",
                    Description = ""
                },
                new ProductTranslation() {
                    Id = 2,
                    ProductId = 1,
                    Name = "Ứng dụng thiết kế online Autocad, Photoshop, illustor, 3D Max ",
                    LanguageId = "vi-VN",
                    SeoAlias = "Acrobat Pro, Photoshop, Illustrator, InDesign, Premiere Pro, After Effects, Lightroom, XD, Animate, LIghtroom Classic, Dreamweaver",
                    SeoDescription = "Acrobat Pro, Photoshop, Illustrator, InDesign, Premiere Pro, After Effects, Lightroom, XD, Animate, LIghtroom Classic, Dreamweaver",
                    SeoTitle = "Acrobat Pro, Photoshop, Illustrator, InDesign, Premiere Pro, After Effects, Lightroom, XD, Animate, LIghtroom Classic, Dreamweaver",
                    Details = "Nền tảng thiết kế trực tuyến All-in-one",
                    Description = ""
                },
                new ProductTranslation() {
                    Id = 3,
                    ProductId = 2,
                    Name = "Autocad Toolsets",
                    LanguageId = "en-EN",
                    SeoAlias = "Autocad",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "AcrobatAutocad, Inventor, PDMC, 3DsMax",
                    Details = "All-in-One online design Platform",
                    Description = "" },
                new ProductTranslation()
                {
                    Id = 4,
                    ProductId = 2,
                    Name = "Autocad Toolsets ",
                    LanguageId = "vi-VN",
                    SeoAlias = "Autocad",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "Autocad, Inventor, PDMC, 3DsMax",
                    Details = "Nền tảng thiết kế trực tuyến All-in-one",
                    Description = ""
                },
                new ProductTranslation()
                {
                    Id = 5,
                    ProductId = 2,
                    Name = "Inventor",
                    LanguageId = "en-EN",
                    SeoAlias = "Autocad inventor",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "AcrobatAutocad, Inventor, PDMC, 3DsMax",
                    Details = "All-in-One online design Platform",
                    Description = ""
                },
                new ProductTranslation()
                {
                    Id = 6,
                    ProductId = 2,
                    Name = "Inventor ",
                    LanguageId = "vi-VN",
                    SeoAlias = "Autocad Inventor",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "Autocad, Inventor, PDMC, 3DsMax",
                    Details = "Nền tảng thiết kế trực tuyến All-in-one",
                    Description = ""
                },
                new ProductTranslation() {
                    Id = 7,
                    ProductId = 2,
                    Name = "Product Design & Manafacturing Collection",
                    LanguageId = "en-EN",
                    SeoAlias = "Autocad PDMC",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "AcrobatAutocad, Inventor, PDMC, 3DsMax",
                    Details = "All-in-One online design Platform",
                    Description = ""
                },
                new ProductTranslation()
                {
                    Id = 8,
                    ProductId = 2,
                    Name = "Product Design & Manafacturing Collection ",
                    LanguageId = "vi-VN",
                    SeoAlias = "Autocad PDMC",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "Autocad, Inventor, PDMC, 3DsMax",
                    Details = "Nền tảng thiết kế trực tuyến All-in-one",
                    Description = ""
                },
                new ProductTranslation() {
                    Id = 9,
                    ProductId = 2,
                    Name = "3ds Max",
                    LanguageId = "en-EN",
                    SeoAlias = "Autocad 3ds Max",
                    SeoDescription = "Autocad, Inventor, PDMC, 3Ds Max",
                    SeoTitle = "AcrobatAutocad, Inventor, PDMC, 3DsMax",
                    Details = "All-in-One online design Platform",
                    Description = ""
                },
                new ProductTranslation() {
                    Id = 10,
                    ProductId = 2,
                    Name = "3ds Max",
                    LanguageId = "vi-VN",
                    SeoAlias = "Autocad 3ds Max",
                    SeoDescription = "Autocad, Inventor, PDMC, 3DsMax",
                    SeoTitle = "Autocad, Inventor, PDMC, 3DsMax",
                    Details = "Nền tảng thiết kế trực tuyến All-in-one",
                    Description = ""
                });  
            modelBuilder.Entity<ProductInCategory>().HasData(
               new ProductInCategory(){ProductId = 1, CategoryId = 1}
               );
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });
               


            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }

    }
    
}
