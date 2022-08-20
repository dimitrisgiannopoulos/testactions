using System.Text.Json.Serialization;

namespace BookCatalogueAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;


        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}