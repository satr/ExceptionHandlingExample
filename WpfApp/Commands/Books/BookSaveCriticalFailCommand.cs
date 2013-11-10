using System;
using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    public class BookSaveCriticalFailCommand : BookSaveCommandBase
    {
        public BookSaveCriticalFailCommand(BookViewModel bookViewModel, ILogger logger)
            : base(bookViewModel, logger)
        {
        }

        protected override void SaveBook()
        {
            //TODO
            throw new Exception("Critical error occured");
        }
    }
}