using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp.BL;
using WpfApp.Commands.Books;
using WpfApp.WorkServiceReference;

namespace WpfApp.ViewModels
{
    public class BookListViewModel
    {
        public BookListViewModel()
        {
            AddBookCommand = new AddBookCommand(Storage.Logger);
            CloseCommand = new CloseBookListCommand(this, Storage.Logger);
            RefreshCorrectCommand = new RefreshBookListCorrectCommand(this, Storage.Logger);
            RefreshErrorCommand = new RefreshBookListErrorCommand(this, Storage.Logger);
            RefreshCriticalFailCommand = new RefreshBookListCriticalFailCommand(this, Storage.Logger);
            Books = new ObservableCollection<Book>();
        }

        public ICommand RefreshCorrectCommand { get; set; }
        public ICommand RefreshErrorCommand { get; set; }
        public ICommand RefreshCriticalFailCommand { get; set; }

        public ObservableCollection<Book> Books { get; set; }

        public ICommand AddBookCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public event EventHandler OnCloseView;

        

        public void CloseView()
        {
            if (OnCloseView != null)
                OnCloseView(this, EventArgs.Empty);
        }
    }
}