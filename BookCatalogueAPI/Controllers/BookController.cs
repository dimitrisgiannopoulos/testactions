using Microsoft.AspNetCore.Mvc;

namespace BookCatalogueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    { 
        [HttpGet]
        public string GetBooks()
        {
            return "OK";
        }
    }
}
