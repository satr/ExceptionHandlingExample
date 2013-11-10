using Common.Logging;
using WpfApp.Views;

namespace WpfApp.Commands.Books
{
    public class AddBookCommand : CommandBase
    {
        public AddBookCommand(ILogger logger) : base(logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            new BookView().Show();
        }
    }
}