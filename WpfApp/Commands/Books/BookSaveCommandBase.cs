using System.IO;
using Common.Logging;
using WpfApp.BL.Services;
using WpfApp.Properties;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Books
{
    public abstract class BookSaveCommandBase : BookCommandBase
    {
        private bool _cancelClosingView = false;

        protected BookSaveCommandBase(BookViewModel bookViewModel, ILogger logger)
            : base(bookViewModel, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            try
            {
                SaveBook();
            }
            catch (FileNotFoundException e)
            {
                var message = Logger.WriteError(Resources.Message_Cannot_save_book, e);
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

        protected abstract void SaveBook();    }
}