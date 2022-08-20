using Microsoft.EntityFrameworkCore;

namespace BookCatalogueAPI.Models
{
    public class CatalogueContext : DbContext
    {
        public CatalogueContext(DbContextOptions<CatalogueContext> options) : base(options)
        {
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>()
                .HasMany(c => c.Books)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId);

                modelBuilder.Seed();
            }
        }

        public DbSet<Book> Books { get; set;}
        public DbSet<Category> Categories { get; set;}

    }
}