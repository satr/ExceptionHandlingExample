using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    public class BookSaveCorrectCommand : BookSaveCommandBase
    {
        public BookSaveCorrectCommand(BookViewModel bookViewModel, ILogger logger) : base(bookViewModel, logger)
        {
        }

        protected override void SaveBook()
        {
            //TODO
        }
    }
}