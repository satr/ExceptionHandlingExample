using System.Windows.Controls;
using Common.Logging;
using WpfApp.Models;
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
            DataContext = new LogViewModel(new LogModel(LogSeverity.Critical, LogSeverity.Error, LogSeverity.Warning, LogSeverity.Info));
        }
    }
}
