using System.ServiceModel;
using Common.Logging;
using WpfApp.BL.Services;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public abstract class BookListCommandBase : CommandBase<FaultException<UnrecoverableFault>>
    {
        protected BookListCommandBase(BookListViewModel bookListViewModel, ILogger logger) : base(logger)
        {
            BookListViewModel = bookListViewModel;
        }

        protected BookListViewModel BookListViewModel { get; set; }

        protected static IWorkService Service
        {
            get { return ServiceLocator.Get<WorkService>().Instance; }
        }

        protected void CloseBookListView()
        {
            BookListViewModel.CloseView();
        }
    }
}