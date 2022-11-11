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
                    new Author { Name = "Harper", Surname = "Lee"},
                    new Author { Name = "J. D.", Surname = "Salinger"},
                    new Author { Name = "F. Scott", Surname = "Fitzgerald"},
                    new Author { Name = "Emily", Surname = "Brontë"},
                    new Author { Name = "Charlotte", Surname = "Brontë"},
                    new Author { Name = "Joseph", Surname = "Heller"},
                    new Author { Name = "Gabriel García", Surname = "Márquez"},
                    new Author { Name = "Jane", Surname = "Austen"},
                    new Author { Name = "Charles", Surname = "Dickens"},
                    new Author { Name = "J. R. R.", Surname = "Tolkien"},
                    new Author { Name = "Toni", Surname = "Morrison"},
                    new Author { Name = "John", Surname = "Steinbeck"},
                    new Author { Name = "Leo", Surname = "Tolstoy"},
                    new Author { Name = "Fyodor", Surname = "Dostoevsky"},
                    new Author { Name = "William", Surname = "Golding"},
                    new Author { Name = "George", Surname = "Orwell"},
                    new Author { Name = "Chinua", Surname = "Achebe"},
                    new Author { Name = "Miguel", Surname = "de Cervantes"},
                    new Author { Name = "Aldous", Surname = "Huxley"},
                    new Author { Name = "Ralph", Surname = "Ellison"},
                    new Author { Name = "Ray", Surname = "Bradbury"},
                    new Author { Name = "Margaret", Surname = "Atwood"},
                    new Author { Name = "Alice", Surname = "Walker"},
                    new Author { Name = "Margaret", Surname = "Mitchell"}
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
                    new Book { Title = "To Kill a Mockingbird",         Authors = new List<Author>(){ authors.Find(i => i.Name == "Harper"         && i.Surname == "Lee") },           Category = "thriller"},
                    new Book { Title = "To Kill a Mockingbird 2",       Authors = new List<Author>(){ authors.Find(i => i.Name == "Harper"         && i.Surname == "Lee") },           Category = "thriller"},
                    new Book { Title = "The Catcher in the Rye",        Authors = new List<Author>(){ authors.Find(i => i.Name == "J. D."           && i.Surname == "Salinger") },     Category = "fiction"},
                    new Book { Title = "The Great Gatsby",              Authors = new List<Author>(){ authors.Find(i => i.Name == "F. Scott"        && i.Surname == "Fitzgerald") },   Category = "fiction"},
                    new Book { Title = "Wuthering Heights",             Authors = new List<Author>(){ authors.Find(i => i.Name == "Emily"           && i.Surname == "Brontë") },       Category = "romance"},
                    new Book { Title = "Jane Eyre",                     Authors = new List<Author>(){ authors.Find(i => i.Name == "Charlotte"       && i.Surname == "Brontë") },       Category = "romance"},
                    new Book { Title = "Catch-22",                      Authors = new List<Author>(){ authors.Find(i => i.Name == "Joseph"          && i.Surname == "Heller") },       Category = "satire"},
                    new Book { Title = "One Hundred Years of Solitude", Authors = new List<Author>(){ authors.Find(i => i.Name == "Gabriel García"  && i.Surname == "Márquez") },        Category = "high fantasy"},
                    new Book { Title = "Pride and Prejudice",           Authors = new List<Author>(){ authors.Find(i => i.Name == "Jane"            && i.Surname == "Austen") },       Category = "romance"},
                    new Book { Title = "Great Expectations",            Authors = new List<Author>(){ authors.Find(i => i.Name == "Charles"         && i.Surname == "Dickens") },      Category = "fiction"},
                    new Book { Title = "The Lord of the Rings",         Authors = new List<Author>(){ authors.Find(i => i.Name == "J. R. R."        && i.Surname == "Tolkien") },      Category = "high fantasy"},
                    new Book { Title = "Beloved",                       Authors = new List<Author>(){ authors.Find(i => i.Name == "Toni"            && i.Surname == "Morrison") },     Category = "fiction"},
                    new Book { Title = "The Grapes of Wrath",           Authors = new List<Author>(){ authors.Find(i => i.Name == "John"            && i.Surname == "Steinbeck") },    Category = "fiction"},
                    new Book { Title = "Anna Karenina",                 Authors = new List<Author>(){ authors.Find(i => i.Name == "Leo"             && i.Surname == "Tolstoy") },      Category = "fiction"},
                    new Book { Title = "Crime and Punishment",          Authors = new List<Author>(){ authors.Find(i => i.Name == "Fyodor"          && i.Surname == "Dostoevsky") },   Category = "thriller"},
                    new Book { Title = "Lord of the Flies",             Authors = new List<Author>(){ authors.Find(i => i.Name == "William"         && i.Surname == "Golding") },      Category = "fiction"},
                    new Book { Title = "Animal Farm",                   Authors = new List<Author>(){ authors.Find(i => i.Name == "George"          && i.Surname == "Orwell") },       Category = "satire"},
                    new Book { Title = "Things Fall Apart",             Authors = new List<Author>(){ authors.Find(i => i.Name == "Chinua"          && i.Surname == "Achebe") },       Category = "fiction"},
                    new Book { Title = "Don Quixote",                   Authors = new List<Author>(){ authors.Find(i => i.Name == "Miguel"          && i.Surname == "de Cervantes") }, Category = "satire"},
                    new Book { Title = "Brave New World",               Authors = new List<Author>(){ authors.Find(i => i.Name == "Aldous"          && i.Surname == "Huxley") },       Category = "fiction"},
                    new Book { Title = "Invisible Man",                 Authors = new List<Author>(){ authors.Find(i => i.Name == "Ralph"           && i.Surname == "Ellison") },      Category = "fiction"},
                    new Book { Title = "Fahrenheit 451",                Authors = new List<Author>(){ authors.Find(i => i.Name == "Ray"             && i.Surname == "Bradbury") },     Category = "fiction"},
                    new Book { Title = "The Handmaid's Tale",           Authors = new List<Author>(){ authors.Find(i => i.Name == "Margaret"        && i.Surname == "Atwood") },       Category = "fiction"},
                    new Book { Title = "The Color Purple",              Authors = new List<Author>(){ authors.Find(i => i.Name == "Alice"           && i.Surname == "Walker") },       Category = "fiction"},
                    new Book { Title = "Gone with the Wind",            Authors = new List<Author>(){ authors.Find(i => i.Name == "Margaret"        && i.Surname == "Mitchell") },     Category = "romance"});

                db.SaveChanges();
            }
        }
    }
}
