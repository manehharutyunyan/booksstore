using BooksLibraryWebApi.Models;
using BooksLibraryWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BooksLibraryWebApi.Controllers
{
    [Route("api/Book/")]
    [ApiController]
    public class BooksController : Controller
    {
        private BookRepository bookRepository;
        public BooksController()
        {
            bookRepository = new BookRepository();
        }
        [HttpGet]
        public JsonResult GetAllBooks()
        {
            return Json(bookRepository.GetBooks());
        }

        [Route("{id}")]
        [HttpGet]
        public BookDTO GetBookById(string id)
        {
            var bookById = bookRepository.GetBookById(int.Parse(id));
            return bookById;
        }

        [HttpPost]        
        public void AddBook([FromBody]BookDTO book)
        {
            bookRepository.AddBook(book);           
        }

        [HttpPut]
        public void UpdateBook([FromQuery]string id)
        {
            var book = BookRepository.books.Where(x => x.Id == int.Parse(id)).FirstOrDefault();
            book.Title = "new title";
        }

    }
}
