using System.Windows.Controls;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : UserControl
    {
        public LogView()
        {
            InitializeComponent();
            DataContext = new LogViewModel();
        }
    }
}
