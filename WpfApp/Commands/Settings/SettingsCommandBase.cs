using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Settings
{
    public abstract class SettingsCommandBase : CommandBase
    {
        protected SettingsViewModel SettingsViewModel { get; set; }

        protected SettingsCommandBase(SettingsViewModel settingsViewModel, ILogger logger) : base(logger)
        {
            SettingsViewModel = settingsViewModel;
        }

        protected void CloseView()
        {
            SettingsViewModel.CloseView();
        }
    }
}