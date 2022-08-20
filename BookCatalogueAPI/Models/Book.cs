namespace BookCatalogueAPI.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
    }
}