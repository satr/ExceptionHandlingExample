using System.ServiceModel;
using Common.Logging;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public abstract class BookCommandBase : CommandBase<FaultException<UnrecoverableFault>>
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