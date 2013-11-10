using Common.Logging;
using WpfApp.BL;
using WpfApp.BL.Services;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Settings
{
    public class SettingsSaveErrorCommand : SettingsSaveCommandBase
    {
        public SettingsSaveErrorCommand(SettingsViewModel settingsViewModel, ILogger logger) 
            : base(settingsViewModel, logger)
        {
        }

        protected override void SaveSettings()
        {
            ServiceLocator.Get<SettingsService>().SaveError(SettingsViewModel.NewSettings);
        }

    }
}