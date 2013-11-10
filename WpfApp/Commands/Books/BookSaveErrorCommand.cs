using System.IO;
using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    public class BookSaveErrorCommand : BookSaveCommandBase
    {
        public BookSaveErrorCommand(BookViewModel bookViewModel, ILogger logger) : base(bookViewModel, logger)
        {
        }

        protected override void SaveBook()
        {
            //TODO
            throw new FileNotFoundException("TODO");
        }
    }
}