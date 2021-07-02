using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokh_Design.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chair", Description = "All-Hand Made Chairs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Pouf", Description = "Elegant Leather Piece" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "ArmChair", Description = "Get the comfort that you deserve" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Lamp", Description = "Smart lamp with the best design ever" });



            //seed Products
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, Name = "Old Chair refurbished", LongDescription = "An old chair refurbished. supple sheepskin with primitive fish motifs.", ShortDescription = "Lorem Ipsum", Price = 3450, InStock = true, IsProductOfTheWeek = true, CategoryId = 1, ImageUrl = "/images/OldChair.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865754870199372/3486078438166989/" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, Name = "Hand painted Chair", LongDescription = "Hand painted #orginal #art", ShortDescription = "Lorem Ipsum", Price = 4999, InStock = true, IsProductOfTheWeek = true, CategoryId=1, ImageUrl = "/images/HandPaintedChair.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865754870199372/2359173760857468/" });
            modelBuilder.Entity<Product>().HasData( new Product { ProductId = 2, Name = "Round Pouf", LongDescription = "Round pouf Manufacture of vegetal leather, painted and painted by hand Dimensions: 35 × 65 × 65 Removable cover.", ShortDescription = "Lorem Ipsum", Price = 500, InStock = true, IsProductOfTheWeek = true, CategoryId = 2, ImageUrl = "/images/RoundPouf.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.866175150157344/1214016528706536/" });
            modelBuilder.Entity<Product>().HasData (new Product { ProductId = 4, Name = "Arm Chair", LongDescription = "Made by humans in Tunisian fabric", ShortDescription = "Lorem Ipsum", Price = 3450, InStock = true, IsProductOfTheWeek = false, CategoryId= 3, ImageUrl = "/images/BigArm.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/" });
            modelBuilder.Entity<Product>().HasData (new Product { ProductId = 5, Name = "Blue Chair", LongDescription = "Made by humans in Tunisian fabric", ShortDescription = "Lorem Ipsum", Price = 3450, InStock = true, IsProductOfTheWeek = false, CategoryId =3, ImageUrl = "/images/blueChair.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/" });
            modelBuilder.Entity<Product>().HasData( new Product { ProductId = 6, Name = "Yellow Chair", LongDescription = "Made by humans in Tunisian fabric", ShortDescription = "Lorem Ipsum", Price = 3450, InStock = true, IsProductOfTheWeek = false, CategoryId=3 , ImageUrl = "/images/YellowChair.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/" });
            modelBuilder.Entity<Product>().HasData (new Product { ProductId = 7, Name = "Green  Chair", LongDescription = "Made by humans in Tunisian fabric", ShortDescription = "Lorem Ipsum", Price = 3450, InStock = true, IsProductOfTheWeek = false, CategoryId=3,  ImageUrl = "/images/GreenChair.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/" });
            modelBuilder.Entity<Product>().HasData (new Product { ProductId = 8, Name = "Big Chair and Pouf", LongDescription = "Made by humans in Tunisian fabric", ShortDescription = "Lorem Ipsum", Price = 3450, InStock = true, IsProductOfTheWeek = true, CategoryId = 3, ImageUrl = "/images/BigArmAndPouf.jpg", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/" });
            modelBuilder.Entity<Product>().HasData (new Product { ProductId = 9, Name = "lamp", LongDescription = "Those lamps Made by humans in Tunisian fabric", ShortDescription = "Lorem Ipsum", Price = 1500, InStock = true, IsProductOfTheWeek = true, CategoryId = 4, ImageUrl = "/images/lamp.png", ImageThumbnailUrl = "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/" });


        }
    }
}
