using System.Windows;
using WpfApp.BL;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : Window
    {

        public SettingsView()
        {
            InitializeComponent();
            var settingsViewModel = new SettingsViewModel(Storage.Settings, Storage.Logger);
            DataContext = settingsViewModel;
            settingsViewModel.OnCloseView += (s, e) => Close();
        }
    }
}
