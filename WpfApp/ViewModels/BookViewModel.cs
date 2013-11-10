using System;
using System.Windows.Input;
using Common.Logging;
using WpfApp.Commands.Books;

namespace WpfApp.ViewModels
{
    public class BookViewModel
    {
        private object _book;
        public event EventHandler OnCloseView;

        public BookViewModel(ILogger logger)
        {
            SaveCorrectCommand = new BookSaveCorrectCommand(this, logger);
            SaveCriticalFailCommand = new BookSaveCriticalFailCommand(this, logger);
            SaveErrorCommand = new BookSaveErrorCommand(this, logger);
            CancelCommand = new BookCancelCommand(this, logger);
            _book = new object();
        }

        public ICommand CancelCommand { get; set; }
        public ICommand SaveCorrectCommand { get; set; }
        public ICommand SaveCriticalFailCommand { get; set; }
        public ICommand SaveErrorCommand { get; set; }

        public object Book { get; private set; }

        public int Pages
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public void CloseView()
        {
            if (OnCloseView != null)
                OnCloseView(this, EventArgs.Empty);
        }
    }
}