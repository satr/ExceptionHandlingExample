using System;
using System.Windows.Input;
using Common.Logging;
using WpfApp.Commands.Books;
using WpfApp.WorkServiceReference;

namespace WpfApp.ViewModels
{
    public class BookViewModel
    {
        public event EventHandler OnCloseView;

        public BookViewModel(ILogger logger)
        {
            SaveCorrectCommand = new BookSaveCorrectCommand(this, logger);
            SaveCriticalFailCommand = new BookSaveCriticalFailCommand(this, logger);
            SaveErrorCommand = new BookSaveErrorCommand(this, logger);
            CancelCommand = new BookCancelCommand(this, logger);
            Book = new Book();
        }

        public ICommand CancelCommand { get; set; }
        public ICommand SaveCorrectCommand { get; set; }
        public ICommand SaveCriticalFailCommand { get; set; }
        public ICommand SaveErrorCommand { get; set; }

        public Book Book { get; private set; }

        public int Pages
        {
            get { return Book.Pages; }
            set { Book.Pages = value; }
        }

        public string Title
        {
            get { return Book.Title; }
            set { Book.Title = value; }
        }

        public void CloseView()
        {
            if (OnCloseView != null)
                OnCloseView(this, EventArgs.Empty);
        }
    }
}