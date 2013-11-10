using System.Collections.Generic;
using Common.Logging;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public abstract class RefreshBookListCommandBase : BookListCommandBase
    {
        protected RefreshBookListCommandBase(BookListViewModel bookListViewModel, ILogger logger) : base(bookListViewModel, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            BookListViewModel.Books.Clear();
            foreach (var book in GetBookList())
            {
                BookListViewModel.Books.Add(book);
            }
        }

        protected abstract IEnumerable<Book> GetBookList();
    }
}