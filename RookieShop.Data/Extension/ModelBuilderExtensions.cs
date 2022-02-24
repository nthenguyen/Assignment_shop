using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RookieShop.Data.Entities;
using RookieShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieShop.Data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category()
             {
                 Id = 1,
                 IsShowOnHome = true,
                 ParentId = null,
                 SortOrder = 1,
                 Status = Status.Active,
                 Name = "Áo thun nam"
             },
            new Category()
            {
                Id = 2,
                IsShowOnHome = true,
                ParentId = null,
                SortOrder = 2,
                Status = Status.Active,
                Name = "Áo Nữ"
            });

            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id = 1,
                DateCreated = DateTime.Now,
                OriginalPrice = 100000,
                Price = 200000,
                Stock = 0,
                ViewCount = 0,
                Name = "Áo Hoodie",
                Detail = "Áo hoodie nam",
                Description = "Áo hoodie dành cho nam"
            },
 
             new Product()
             {
                 Id = 2,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 100000,
                 Price = 200000,
                 Stock = 0,
                 ViewCount = 0,
                 Name = "Áo jacket",
                 Detail = "Áo jacket nam",
                 Description = "Áo jacket dành cho nam"
             }
            ) ;
           
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 1 }
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

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "ntnguyen@gmail.com",
                NormalizedEmail = "ntnguyen@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen",
                LastName = "Nguyen",
                Dob = new DateTime(2000, 03, 27)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}
