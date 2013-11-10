using Common.Logging;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public class BookSaveCorrectCommand : BookSaveCommandBase
    {
        public BookSaveCorrectCommand(BookViewModel bookViewModel, ILogger logger) : base(bookViewModel, logger)
        {
        }

        protected override void SaveBook(Book book)
        {
            Service.SaveCorrect(book);
        }
    }
}