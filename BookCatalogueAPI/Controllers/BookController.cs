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
        public ActionResult GetAllBooks()
        {
            return Ok(_context.Books.ToArray());
        }

        [HttpGet("{id}")]
        public ActionResult GetBook(int id) {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
