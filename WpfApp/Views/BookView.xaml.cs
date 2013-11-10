using System.Windows;
using WpfApp.BL;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : Window
    {
        public BookView()
        {
            InitializeComponent();
            var bookViewModel = new BookViewModel(Storage.Logger);
            DataContext = bookViewModel;
            bookViewModel.OnCloseView += (s, e) => Close();
        }
    }
}
