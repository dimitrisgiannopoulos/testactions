using System.ComponentModel.DataAnnotations;

namespace BookCatalogueAPI.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Surname { get; set; } = string.Empty;

        public virtual List<Book>? Books { get; set; }

        public DateOnly dateOfBirth { get; set; }

        public DateOnly dateOfDeath { get; set; }

        public string countryOfBirth { get; set; } = string.Empty;
    }
}
