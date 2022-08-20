using Microsoft.EntityFrameworkCore;

namespace BookCatalogueAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Wear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" });

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, CategoryId = 1, Title= "Grunge Skater Jeans", Author = "AWMGSJ" },
                new Book { Id = 1, CategoryId = 1, Title= "Grunge Skater Jeans", Author = "AWMGSJ" },
                new Book { Id = 1, CategoryId = 1, Title= "Grunge Skater Jeans", Author = "AWMGSJ" },
                new Book { Id = 2, CategoryId = 1, Title= "Polo Shirt", Author = "AWMPS" },
                new Book { Id = 3, CategoryId = 1, Title= "Skater Graphic T-Shirt", Author = "AWMSGT" },
                new Book { Id = 4, CategoryId = 1, Title= "Slicker Jacket", Author = "AWMSJ" },
                new Book { Id = 5, CategoryId = 1, Title= "Thermal Fleece Jacket", Author = "AWMTFJ" },
                new Book { Id = 6, CategoryId = 1, Title= "Unisex Thermal Vest", Author = "AWMUTV" },
                new Book { Id = 7, CategoryId = 1, Title= "V-Neck Pullover", Author = "AWMVNP" },
                new Book { Id = 8, CategoryId = 1, Title= "V-Neck Sweater", Author = "AWMVNS" },
                new Book { Id = 9, CategoryId = 1, Title= "V-Neck T-Shirt", Author = "AWMVNT" },
                new Book { Id = 10, CategoryId = 2, Title = "Bamboo Thermal Ski Coat", Author = "AWWBTSC" },
                new Book { Id = 11, CategoryId = 2, Title = "Cross-Back Training Tank", Author = "AWWCTT" },
                new Book { Id = 12, CategoryId = 2, Title = "Grunge Skater Jeans", Author = "AWWGSJ" },
                new Book { Id = 13, CategoryId = 2, Title = "Slicker Jacket", Author = "AWWSJ" },
                new Book { Id = 14, CategoryId = 2, Title = "Stretchy Dance Pants", Author = "AWWSDP" },
                new Book { Id = 15, CategoryId = 2, Title = "Ultra-Soft Tank Top", Author = "AWWUTT" },
                new Book { Id = 16, CategoryId = 2, Title = "Unisex Thermal Vest", Author = "AWWUTV" },
                new Book { Id = 17, CategoryId = 2, Title = "V-Next T-Shirt", Author = "AWWVNT" },
                new Book { Id = 18, CategoryId = 3, Title = "Blueberry Mineral Water", Author = "MWB" },
                new Book { Id = 19, CategoryId = 3, Title = "Lemon-Lime Mineral Water", Author = "MWLL" },
                new Book { Id = 20, CategoryId = 3, Title = "Orange Mineral Water", Author = "MWO" },
                new Book { Id = 21, CategoryId = 3, Title = "Peach Mineral Water", Author = "MWP" },
                new Book { Id = 22, CategoryId = 3, Title = "Raspberry Mineral Water", Author = "MWR" },
                new Book { Id = 23, CategoryId = 3, Title = "Strawberry Mineral Water", Author = "MWS" },
                new Book { Id = 24, CategoryId = 4, Title = "In the Kitchen with H+ Sport", Author = "PITK" },
                new Book { Id = 25, CategoryId = 5, Title = "Calcium 400 IU (150 tablets)", Author = "SC400" },
                new Book { Id = 26, CategoryId = 5, Title = "Flaxseed Oil 100 mg (90 capsules)", Author = "SFO100" },
                new Book { Id = 27, CategoryId = 5, Title = "Iron 65 mg (150 caplets)", Author = "SI65" },
                new Book { Id = 28, CategoryId = 5, Title = "Magnesium 250 mg (100 tablets)", Author = "SM250" },
                new Book { Id = 29, CategoryId = 5, Title = "Multi-Vitamin (90 capsules)", Author = "SMV" },
                new Book { Id = 30, CategoryId = 5, Title = "Vitamin A 10,000 IU (125 caplets)", Author = "SVA" },
                new Book { Id = 31, CategoryId = 5, Title = "Vitamin B-Complex (100 caplets)", Author = "SVB" },
                new Book { Id = 32, CategoryId = 5, Title = "Vitamin C 1000 mg (100 tablets)", Author = "SVC"},
                new Book { Id = 33, CategoryId = 5, Title = "Vitamin D3 1000 IU (100 tablets)", Author = "SVD3" });
        }
    }
}
