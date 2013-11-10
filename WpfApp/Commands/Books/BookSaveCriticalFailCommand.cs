using System;
using Common.Logging;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public class BookSaveCriticalFailCommand : BookSaveCommandBase
    {
        public BookSaveCriticalFailCommand(BookViewModel bookViewModel, ILogger logger)
            : base(bookViewModel, logger)
        {
        }

        protected override void SaveBook(Book book)
        {
            Service.SaveCriticalFail(book);
        }
    }
}