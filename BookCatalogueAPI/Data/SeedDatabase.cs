using BookCatalogueAPI.Models;

namespace BookCatalogueAPI.Data
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            using (var db = new BookCatalogueContext())
            {
                // Makes the seeding idempotent
                if (!db.Database.EnsureCreated()) return;

                db.Categories.AddRange(
                    new Category { Id = 1, Name = "thriller" },
                    new Category { Id = 2, Name = "fiction" },
                    new Category { Id = 3, Name = "romance" },
                    new Category { Id = 4, Name = "satire" },
                    new Category { Id = 5, Name = "high fantasy" });

                db.Books.AddRange(
                    new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", CategoryId = 1 },
                    new Book { Title = "The Catcher in the Rye", Author = "J. D. Salinger", CategoryId = 2 },
                    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" , CategoryId = 2},
                    new Book { Title = "Wuthering Heights", Author = "Emily Brontë", CategoryId = 3 },
                    new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", CategoryId = 3},
                    new Book { Title = "Catch-22", Author = "Joseph Heller", CategoryId = 4 },
                    new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", CategoryId = 5 },
                    new Book { Title = "Pride and Prejudice", Author = "Jane Austen", CategoryId = 3 },
                    new Book { Title = "Great Expectations", Author = "Charles Dickens", CategoryId = 2 },
                    new Book { Title = "The Lord of the Rings", Author = "J. R. R. Tolkien", CategoryId = 5 },
                    new Book { Title = "Beloved", Author = "Toni Morrison", CategoryId = 2 },
                    new Book { Title = "The Grapes of Wrath", Author = "John Steinbeck", CategoryId = 2 },
                    new Book { Title = "Anna Karenina", Author = "Leo Tolstoy", CategoryId = 2 },
                    new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", CategoryId = 1 },
                    new Book { Title = "Lord of the Flies", Author = "William Golding", CategoryId = 2 },
                    new Book { Title = "Animal Farm", Author = "George Orwell", CategoryId = 4 },
                    new Book { Title = "Things Fall Apart", Author = "Chinua Achebe", CategoryId = 2 },
                    new Book { Title = "Don Quixote", Author = "Miguel de Cervantes", CategoryId = 4 },
                    new Book { Title = "Brave New World", Author = "Aldous Huxley", CategoryId = 2 },
                    new Book { Title = "Invisible Man", Author = "Ralph Ellison", CategoryId = 2 },
                    new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", CategoryId = 2 },
                    new Book { Title = "The Handmaid's Tale", Author = "Margaret Atwood", CategoryId = 2 },
                    new Book { Title = "The Color Purple", Author = "Alice Walker", CategoryId = 2 },
                    new Book { Title = "Gone with the Wind", Author = "Margaret Mitchell", CategoryId = 3 });
                
                db.SaveChanges();
            }
        }
    }
}
