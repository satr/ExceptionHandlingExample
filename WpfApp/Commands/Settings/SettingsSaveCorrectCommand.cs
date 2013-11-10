using Common.Logging;
using WpfApp.BL;
using WpfApp.BL.Services;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Settings
{
    public class SettingsSaveCorrectCommand : SettingsSaveCommandBase
    {
        public SettingsSaveCorrectCommand(SettingsViewModel settingsViewModel, ILogger logger) 
            : base(settingsViewModel, logger)
        {
        }

        protected override void SaveSettings()
        {
            ServiceLocator.Get<SettingsService>().SaveCorrect(SettingsViewModel.NewSettings);
        }
    }
}