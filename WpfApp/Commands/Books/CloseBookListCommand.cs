using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    class CloseBookListCommand : BookListCommandBase
    {
        public CloseBookListCommand(BookListViewModel bookViewModel, ILogger logger) : base(bookViewModel, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            CloseBookListView();
        }
    }
}