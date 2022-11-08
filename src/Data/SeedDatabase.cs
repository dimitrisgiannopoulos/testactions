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

                db.Authors.AddRange(
                    new Author {Name = "Harper Lee"},
                    new Author {Name = "J. D. Salinger"},
                    new Author {Name = "F. Scott Fitzgerald" },
                    new Author {Name = "Emily Brontë"},
                    new Author {Name = "Charlotte Brontë"},
                    new Author {Name = "Joseph Heller"},
                    new Author {Name = "Gabriel García Márquez"},
                    new Author {Name = "Jane Austen"},
                    new Author {Name = "Charles Dickens"},
                    new Author {Name = "J. R. R. Tolkien"},
                    new Author {Name = "Toni Morrison"},
                    new Author {Name = "John Steinbeck"},
                    new Author {Name = "Leo Tolstoy"},
                    new Author {Name = "Fyodor Dostoevsky"},
                    new Author {Name = "William Golding"},
                    new Author {Name = "George Orwell"},
                    new Author {Name = "Chinua Achebe"},
                    new Author {Name = "Miguel de Cervantes"},
                    new Author {Name = "Aldous Huxley"},
                    new Author {Name = "Ralph Ellison"},
                    new Author {Name = "Ray Bradbury"},
                    new Author {Name = "Margaret Atwood"},
                    new Author {Name = "Alice Walker"},
                    new Author {Name = "Margaret Mitchell"}
                );
                
                db.Categories.AddRange(
                    new Category { Name = "thriller" },
                    new Category { Name = "fiction" },
                    new Category { Name = "romance" },
                    new Category { Name = "satire" },
                    new Category { Name = "high fantasy" });

                db.Books.AddRange(
                    new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Category = "thriller" },
                    new Book { Title = "The Catcher in the Rye", Author = "J. D. Salinger", Category = "fiction" },
                    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" , Category = "fiction"},
                    new Book { Title = "Wuthering Heights", Author = "Emily Brontë", Category = "romance" },
                    new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", Category = "romance"},
                    new Book { Title = "Catch-22", Author = "Joseph Heller", Category = "satire" },
                    new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", Category = "high fantasy" },
                    new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Category = "romance" },
                    new Book { Title = "Great Expectations", Author = "Charles Dickens", Category = "fiction" },
                    new Book { Title = "The Lord of the Rings", Author = "J. R. R. Tolkien", Category = "high fantasy" },
                    new Book { Title = "Beloved", Author = "Toni Morrison", Category = "fiction" },
                    new Book { Title = "The Grapes of Wrath", Author = "John Steinbeck", Category = "fiction" },
                    new Book { Title = "Anna Karenina", Author = "Leo Tolstoy", Category = "fiction" },
                    new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Category = "thriller" },
                    new Book { Title = "Lord of the Flies", Author = "William Golding", Category = "fiction" },
                    new Book { Title = "Animal Farm", Author = "George Orwell", Category = "satire" },
                    new Book { Title = "Things Fall Apart", Author = "Chinua Achebe", Category = "fiction" },
                    new Book { Title = "Don Quixote", Author = "Miguel de Cervantes", Category = "satire" },
                    new Book { Title = "Brave New World", Author = "Aldous Huxley", Category = "fiction" },
                    new Book { Title = "Invisible Man", Author = "Ralph Ellison", Category = "fiction" },
                    new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", Category = "fiction" },
                    new Book { Title = "The Handmaid's Tale", Author = "Margaret Atwood", Category = "fiction" },
                    new Book { Title = "The Color Purple", Author = "Alice Walker", Category = "fiction" },
                    new Book { Title = "Gone with the Wind", Author = "Margaret Mitchell", Category = "romance" });
                
                db.SaveChanges();
            }
        }
    }
}
