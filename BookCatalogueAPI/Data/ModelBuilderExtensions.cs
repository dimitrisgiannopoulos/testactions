using Microsoft.EntityFrameworkCore;

namespace BookCatalogueAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Thriller" },
                new Category { Id = 2, Name = "Fiction" },
                new Category { Id = 3, Name = "Romance" },
                new Category { Id = 4, Name = "Satire" },
                new Category { Id = 5, Name = "High Fantasy" });

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, CategoryId = 1, Title= "To Kill a Mockingbird", Author = "Harper Lee" },
                new Book { Id = 2, CategoryId = 2, Title= "The Catcher in the Rye", Author = "J. D. Salinger" },
                new Book { Id = 3, CategoryId = 2, Title= "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new Book { Id = 4, CategoryId = 3, Title= "Wuthering Heights", Author = "Emily Brontë" },
                new Book { Id = 5, CategoryId = 3, Title= "Jane Eyre", Author = "Charlotte Brontë" },
                new Book { Id = 6, CategoryId = 4, Title= "Catch-22", Author = "Joseph Heller" },
                new Book { Id = 7, CategoryId = 5, Title= "One Hundred Years of Solitude", Author = "Gabriel García Márquez" },
                new Book { Id = 8, CategoryId = 3, Title= "Pride and Prejudice", Author = "Jane Austen" },
                new Book { Id = 9, CategoryId = 2, Title= "Great Expectations", Author = "Charles Dickens" },
                new Book { Id = 10, CategoryId = 5, Title = "The Lord of the Rings", Author = "J. R. R. Tolkien" },
                new Book { Id = 11, CategoryId = 2, Title = "Beloved", Author = "Toni Morrison" },
                new Book { Id = 12, CategoryId = 2, Title = "The Grapes of Wrath", Author = "John Steinbeck" },
                new Book { Id = 13, CategoryId = 2, Title = "Anna Karenina", Author = "Leo Tolstoy" },
                new Book { Id = 14, CategoryId = 1, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky" },
                new Book { Id = 15, CategoryId = 2, Title = "Lord of the Flies", Author = "William Golding" },
                new Book { Id = 16, CategoryId = 4, Title = "Animal Farm", Author = "George Orwell" },
                new Book { Id = 17, CategoryId = 2, Title = "Things Fall Apart", Author = "Chinua Achebe" },
                new Book { Id = 18, CategoryId = 4, Title = "Don Quixote", Author = "Miguel de Cervantes" },
                new Book { Id = 19, CategoryId = 2, Title = "Brave New World", Author = "Aldous Huxley" },
                new Book { Id = 20, CategoryId = 2, Title = "Invisible Man", Author = "Ralph Ellison" },
                new Book { Id = 21, CategoryId = 2, Title = "Fahrenheit 451", Author = "Ray Bradbury" },
                new Book { Id = 22, CategoryId = 2, Title = "The Handmaid's Tale", Author = "Margaret Atwood" },
                new Book { Id = 23, CategoryId = 2, Title = "The Color Purple", Author = "Alice Walker" },
                new Book { Id = 24, CategoryId = 3, Title = "Gone with the Wind", Author = "Margaret Mitchell" });
        }
    }
}
