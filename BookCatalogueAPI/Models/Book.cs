using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }

        public Book(string title, string author, int categoryid)
        {
            Title = title;
            Author = author;
            CategoryId = categoryid;
        }

        public Book () {}

        public override string ToString()
        {
            return
                "---" + Environment.NewLine +
                "ID " + Id.ToString() + Environment.NewLine +
                "   Title       : " + Title + Environment.NewLine +
                "   Author      : " + Author + Environment.NewLine +
                "   CategoryId  : " + CategoryId.ToString() + Environment.NewLine;
        }
    }
}