using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    public abstract class BookListCommandBase : CommandBase
    {
        protected BookListCommandBase(BookListViewModel bookListViewModel, ILogger logger) : base(logger)
        {
            BookListViewModel = bookListViewModel;
        }

        protected BookListViewModel BookListViewModel { get; set; }

        protected void CloseBookListView()
        {
            BookListViewModel.CloseView();
        }
    }
}