using System.ComponentModel.DataAnnotations;

namespace BookCatalogueAPI.Models
{
    public class Book
    {
        public int Id { get; set; } = 0;

        [Required]
        public string Title { get; set; } = string.Empty;

        public DateOnly dateOfFirstPublication { get; set; }

        [Required]
        public List<Author>? Authors { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        public string originalLanguage { get; set; } = string.Empty;

        public Book(string title, List<Author> authors, string category)
        {
            Title = title;
            Authors = authors;
            Category = category;
        }

        public Book() { }
    }
}