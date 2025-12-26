using Book_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
        };

        [HttpGet]
        public ActionResult<Book[]> GetBooks()
        {
            return Ok(_books);
        }
    }
}
