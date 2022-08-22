using BookCatalogueAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    { 
        private readonly CatalogueContext _context;

        public BookController(CatalogueContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToArray();
        }
    }
}
