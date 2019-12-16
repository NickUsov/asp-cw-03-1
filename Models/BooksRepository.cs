using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class BooksRepository : IRepository
    {
        public int Count => books.Count;
        IList<Book> books = new List<Book>();
        public void Add(Book book)
        {
            books.Add(book);
        }
    }
}