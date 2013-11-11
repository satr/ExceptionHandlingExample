using System;
using System.Collections.ObjectModel;
using System.Linq;
using WcfService.Properties;

namespace WcfService
{
    public class BookManager
    {
        private readonly Collection<Book> _bookList = new Collection<Book>();

        public Collection<Book> GetBookList()
        {
            return _bookList;
        }

        public void Add(Book book)
        {
            if (Storage.BookManager.GetBookList().Any(b => b.Title == book.Title && b.Pages == book.Pages))
                throw new ArgumentException(Resources.Message_This_book_already_exists);
            _bookList.Add(book);
        }
    }
}