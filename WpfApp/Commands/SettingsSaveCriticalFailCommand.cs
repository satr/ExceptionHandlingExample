using Common.Logging;
using WpfApp.BL;
using WpfApp.BL.Services;
using WpfApp.ViewModels;

namespace WpfApp.Commands
{
    public class SettingsSaveCriticalFailCommand : SettingsSaveCommandBase
    {
        public SettingsSaveCriticalFailCommand(SettingsViewModel settingsViewModel, ILogger logger) 
            : base(settingsViewModel, logger)
        {
        }

        protected override void SaveSettings()
        {
            ServiceLocator.Get<SettingsService>().SaveCriticalFail(SettingsViewModel.NewSettings);
        }
    }
}