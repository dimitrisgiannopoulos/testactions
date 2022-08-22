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

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return  CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutBook( int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Books.Any(p => p.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
             _context.Books.Remove(book);
             await _context.SaveChangesAsync();

             return book;
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> DeleteMultiple([FromQuery]int[] ids)
        {
            var books = new List<Book>();
            foreach (var id in ids)
            {
                var book = await _context.Books.FindAsync(id);

                if (book == null)
                {
                    return NotFound();
                }

                books.Add(book);
            }
            
             _context.Books.RemoveRange(books);
             await _context.SaveChangesAsync();

             return Ok(books);
        }
    }
}
