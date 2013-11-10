using System;
using System.Windows.Input;
using WpfApp.BL;
using WpfApp.Commands.Books;

namespace WpfApp.ViewModels
{
    public class BookListViewModel
    {
        public BookListViewModel()
        {
            AddBookCommand = new AddBookCommand(Storage.Logger);
            CloseCommand = new CloseBookListCommand(this, Storage.Logger);
        }

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