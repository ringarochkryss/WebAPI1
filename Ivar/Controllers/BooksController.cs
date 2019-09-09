using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Ivar.Models;

namespace Ivar.Controllers
{

    public class BooksController : ApiController
    {
        static readonly IBookRepository repository = new BookRepository(); //Microsoft also suggests this approach: https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/dependency-injection

 // .........Get All books: /api/books................................
    [Cachefilter(TimeDuration =100)]
        public IEnumerable<Book> GetAllBooks()
        {
            return repository.GetAll();
        }

 
// .........Get book by Title: /api/books?title=title................
        //or if I would like to use routing:  [System.Web.Http.Route("api/book{title[]}")]

        public IEnumerable<Book> GetbooksByTitle(string title)
         {

            return repository.GetAll().Where(
            t => string.Equals(t.Title, title, StringComparison.OrdinalIgnoreCase)); 
        }

 
// ........Get book by Author: /api/books?author=author..............

        public IEnumerable<Book> GetbooksByAuthor(string author)
        {
            return repository.GetAll().Where(
                a => string.Equals(a.Author, author, StringComparison.OrdinalIgnoreCase));
        }

// .........Get book by Genre: /api/books?genre=genre...................
   
        public IEnumerable<Book> GetbooksByGenre(string genre)
        {
            return repository.GetAll().Where(
                g => string.Equals(g.Genre, genre, StringComparison.OrdinalIgnoreCase));
        }

    }
}

