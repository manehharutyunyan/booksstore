using BooksLibraryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksLibraryWebApi.Services
{
    public class BookRepository : IBookRepository
    {
        public static List<BookDTO> books = new List<BookDTO>()
        {
           new BookDTO() { Id = 1, Title = "Title 1" },
           new BookDTO() { Id = 2, Title = "Title 2" },
           new BookDTO() { Id = 3, Title = "Title 3" },
           new BookDTO() { Id = 4, Title = "Title 4" }
        };

        public BookRepository()
        {
        }

        public List<BookDTO> GetBooks()
        {
            return books;
        }

        public void AddBook(BookDTO book)
        {
            books.Add(book);
        }

        public BookDTO GetBookById(int id)
        {
            return books.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
