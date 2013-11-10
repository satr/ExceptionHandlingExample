using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    public abstract class BookCommandBase : CommandBase
    {
        protected BookCommandBase(BookViewModel bookViewModel, ILogger logger) : base(logger)
        {
            BookViewModel = bookViewModel;
        }

        protected BookViewModel BookViewModel { get; set; }

        protected void CloseBookView()
        {
            BookViewModel.CloseView();
        }
    }
}