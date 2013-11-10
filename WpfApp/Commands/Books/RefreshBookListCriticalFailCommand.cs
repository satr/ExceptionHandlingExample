using System.Collections.Generic;
using Common.Logging;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public class RefreshBookListCriticalFailCommand: RefreshBookListCommandBase
    {
        public RefreshBookListCriticalFailCommand(BookListViewModel bookListViewModel, ILogger logger) : base(bookListViewModel, logger)
        {
        }

        protected override IEnumerable<Book> GetBookList()
        {
            return Service.GetBookListCriticalFail();
        }
    }
}