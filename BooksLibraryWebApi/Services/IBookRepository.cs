using BooksLibraryWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksLibraryWebApi.Services
{
    public interface IBookRepository
    {
        List<BookDTO> GetBooks();
        BookDTO GetBookById(int id);
        void AddBook(BookDTO book);
    }
}
