using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    class BookCancelCommand : BookCommandBase
    {
        public BookCancelCommand(BookViewModel bookViewModel, ILogger logger) : base(bookViewModel, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            CloseBookView();
        }
    }
}