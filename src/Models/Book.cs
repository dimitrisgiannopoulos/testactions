using System.ComponentModel.DataAnnotations;

namespace BookCatalogueAPI.Models
{
    public class Book
    {
        public int Id { get; set; } = 0;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        public Book(string title, string author, string category)
        {
            Title = title;
            Author = author;
            Category = category;
        }

        public Book () {}

        public override string ToString()
        {
            return
                "---" + Environment.NewLine +
                "ID " + Id.ToString() + Environment.NewLine +
                "   Title       : " + Title + Environment.NewLine +
                "   Author      : " + Author + Environment.NewLine +
                "   Category    : " + Category + Environment.NewLine;
        }
    }
}