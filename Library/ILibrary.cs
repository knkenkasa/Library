using Library.Book;

namespace Library.Library
{
    public interface ILibrary
    {
        // defined name method
        // Rule: verb + subject
        List<Book.Book> GetBooks();
        Book.Book? GetBook(int id);
        void AddBook(Book.Book book);
        void DeleteBook(int id);
        void UpdateBook(Book.Book book);
    }
}
