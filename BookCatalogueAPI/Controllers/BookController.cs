using BookCatalogueAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult> GetAllBooks()
        {
            return Ok(await _context.Books.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetBook(int id) {
            var book = _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(await book);
        }
    }
}
