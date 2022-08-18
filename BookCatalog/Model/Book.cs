namespace BookCatalog.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}