using Common.Logging;
using WpfApp.Views;

namespace WpfApp.Commands.Main
{
    public class ShowBookListCommand : CommandBase
    {
        public ShowBookListCommand(ILogger logger) : base(logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            var bookListView = new BookListView();
            bookListView.Show();
        }
    }
}