using System.Windows.Controls;
using Common.Logging;
using WpfApp.Models;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for ErrorLogView.xaml
    /// </summary>
    public partial class ErrorLogView : UserControl
    {
        public ErrorLogView()
        {
            InitializeComponent();
            DataContext = new LogViewModel(new LogModel(LogSeverity.Critical, LogSeverity.Error));
        }
    }
}
