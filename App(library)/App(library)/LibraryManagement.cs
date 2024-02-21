using Library.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library
{
    // ten class la danh tu
    public class LibraryManagement : ILibrary
    {
        // private -> inside class
        // protected
        // public

        private readonly List<Book.Book> _bookCollection;

        public LibraryManagement()
        {
            _bookCollection = new List<Book.Book>();
        }

        // properties

        // methods
        public void AddBook(Book.Book book)
        {
            _bookCollection.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book = _bookCollection.Find(e => e.Id == id);

            if (book != null)
            {
                _bookCollection.Remove(book);
            }
        }

        public Book.Book? GetBook(int id)
        {
            return _bookCollection.FirstOrDefault(e => e.Id == id);
        }

        public List<Book.Book> GetBooks()
        {
            return _bookCollection.ToList();
        }

        public void UpdateBook(Book.Book book)
        {
            var bookRecord = _bookCollection.FirstOrDefault(e => e.Id == book.Id);

            if ( bookRecord != null )
            {
                _bookCollection.Remove(bookRecord);

                _bookCollection.Add(book);
            }
        }
    }
}
