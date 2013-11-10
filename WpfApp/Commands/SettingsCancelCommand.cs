using Common.Logging;
using WpfApp.ViewModels;

namespace WpfApp.Commands
{
    public class SettingsCancelCommand: SettingsCommandBase
    {
        public SettingsCancelCommand(SettingsViewModel settingsViewModel, ILogger logger) : base(settingsViewModel, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            CloseView();
        }
    }
}