using System.ServiceModel;
using Common.Logging;
using WpfApp.Views;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public class AddBookCommand : CommandBase<FaultException<UnrecoverableFault>>
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