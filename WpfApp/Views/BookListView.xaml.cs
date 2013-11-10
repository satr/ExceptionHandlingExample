using System.Windows;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for BookListView.xaml
    /// </summary>
    public partial class BookListView : Window
    {
        public BookListView()
        {
            InitializeComponent();
            var bookListViewModel = new BookListViewModel();
            DataContext = bookListViewModel;
            bookListViewModel.OnCloseView += (s, e) => Close();
        }
    }
}
