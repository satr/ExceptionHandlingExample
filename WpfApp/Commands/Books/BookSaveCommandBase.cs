using System.ServiceModel;
using Common.Logging;
using WpfApp.BL.Services;
using WpfApp.Properties;
using WpfApp.ViewModels;
using WpfApp.WorkServiceReference;

namespace WpfApp.Commands.Books
{
    public abstract class BookSaveCommandBase : BookCommandBase
    {
        private bool _cancelClosingView = false;

        protected BookSaveCommandBase(BookViewModel bookViewModel, ILogger logger)
            : base(bookViewModel, logger)
        {
        }

        protected static IWorkService Service
        {
            get { return ServiceLocator.Get<WorkService>().Instance; }
        }

        protected override void ExecuteInternal(object parameter)
        {
            _cancelClosingView = false;
            try
            {
                SaveBook(BookViewModel.Book);
                Logger.WriteInfo(Common.Helpers.GetStringFormatUnchecked(Resources.Message_Book__0__1__pages__added, 
                                                                        BookViewModel.Book.Title, 
                                                                        BookViewModel.Book.Pages));
            }
            catch (FaultException<RecoverableFault> e)
            {
                var message = Common.Helpers.GetStringFormatUnchecked("{0}\n{1}", 
                                                                        Resources.Message_Cannot_perform_operation, 
                                                                        e.Reason);
                Logger.WriteError(message);
                ServiceLocator.Get<HumanInteractionService>().ShowError(message);
                _cancelClosingView = true;
            }
        }

        protected override void FinalizeExecution(object parameter)
        {
            base.FinalizeExecution(parameter);
            if (!_cancelClosingView)
                CloseBookView();
        }

        protected abstract void SaveBook(Book book);    
    }
}