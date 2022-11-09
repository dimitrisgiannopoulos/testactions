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

                List<Author> authors = new List<Author>()
                {
                    new Author ("Harper", "Lee"),
                    new Author ("J. D.", "Salinger"),
                    new Author ("F. Scott", "Fitzgerald"),
                    new Author ("Emily", "Brontë"),
                    new Author ("Charlotte", "Brontë"),
                    new Author ("Joseph", "Heller"),
                    new Author ("Gabriel García", "Márquez"),
                    new Author ("Jane", "Austen"),
                    new Author ("Charles", "Dickens"),
                    new Author ("J. R. R.", "Tolkien"),
                    new Author ("Toni", "Morrison"),
                    new Author ("John", "Steinbeck"),
                    new Author ("Leo", "Tolstoy"),
                    new Author ("Fyodor", "Dostoevsky"),
                    new Author ("William", "Golding"),
                    new Author ("George", "Orwell"),
                    new Author ("Chinua", "Achebe"),
                    new Author ("Miguel", "de Cervantes"),
                    new Author ("Aldous", "Huxley"),
                    new Author ("Ralph", "Ellison"),
                    new Author ("Ray", "Bradbury"),
                    new Author ("Margaret", "Atwood"),
                    new Author ("Alice", "Walker"),
                    new Author ("Margaret", "Mitchell")
                };

                db.Authors.AddRange(authors);

                List<Category> categories = new List<Category>()
                {
                    new Category { Name = "thriller"},
                    new Category { Name = "fiction"},
                    new Category { Name = "romance"},
                    new Category { Name = "satire"},
                    new Category { Name = "high fantasy"}
                };

                db.Categories.AddRange(categories);

                db.Books.AddRange(
                    new Book { Title = "To Kill a Mockingbird", Authors = new List<Author>(){ authors[0] }, Category = "thriller"},
                    new Book { Title = "To Kill a Mockingbird 2", Authors = new List<Author>(){ authors[0] }, Category = "thriller"},
                    new Book { Title = "The Catcher in the Rye", Authors = new List<Author>(){ authors[1] }, Category = "fiction"},
                    new Book { Title = "The Great Gatsby", Authors = new List<Author>(){ authors[2] }, Category = "fiction"},
                    new Book { Title = "Wuthering Heights", Authors = new List<Author>(){ authors[3] }, Category = "romance"},
                    new Book { Title = "Jane Eyre", Authors = new List<Author>(){ authors[4] }, Category = "romance"},
                    new Book { Title = "Catch-22", Authors = new List<Author>(){ authors[5] }, Category = "satire"},
                    new Book { Title = "One Hundred Years of Solitude", Authors = new List<Author>(){ authors[6] }, Category = "high fantasy"},
                    new Book { Title = "Pride and Prejudice", Authors = new List<Author>(){ authors[7] }, Category = "romance"},
                    new Book { Title = "Great Expectations", Authors = new List<Author>(){ authors[8] }, Category = "fiction"},
                    new Book { Title = "The Lord of the Rings", Authors = new List<Author>(){ authors[9] }, Category = "high fantasy"},
                    new Book { Title = "Beloved", Authors = new List<Author>(){ authors[10] }, Category = "fiction"},
                    new Book { Title = "The Grapes of Wrath", Authors = new List<Author>(){ authors[11] }, Category = "fiction"},
                    new Book { Title = "Anna Karenina", Authors = new List<Author>(){ authors[12] }, Category = "fiction"},
                    new Book { Title = "Crime and Punishment", Authors = new List<Author>(){ authors[13] }, Category = "thriller"},
                    new Book { Title = "Lord of the Flies", Authors = new List<Author>(){ authors[14] }, Category = "fiction"},
                    new Book { Title = "Animal Farm", Authors = new List<Author>(){ authors[15] }, Category = "satire"},
                    new Book { Title = "Things Fall Apart", Authors = new List<Author>(){ authors[16] }, Category = "fiction"},
                    new Book { Title = "Don Quixote", Authors = new List<Author>(){ authors[17] }, Category = "satire"},
                    new Book { Title = "Brave New World", Authors = new List<Author>(){ authors[18] }, Category = "fiction"},
                    new Book { Title = "Invisible Man", Authors = new List<Author>(){ authors[19] }, Category = "fiction"},
                    new Book { Title = "Fahrenheit 451", Authors = new List<Author>(){ authors[20] }, Category = "fiction"},
                    new Book { Title = "The Handmaid's Tale", Authors = new List<Author>(){ authors[21] }, Category = "fiction"},
                    new Book { Title = "The Color Purple", Authors = new List<Author>(){ authors[22] }, Category = "fiction"},
                    new Book { Title = "Gone with the Wind", Authors = new List<Author>(){ authors[23] }, Category = "romance"});

                db.SaveChanges();
            }
        }
    }
}
