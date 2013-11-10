using System.IO;
using Common.Logging;
using WpfApp.BL.Services;
using WpfApp.Properties;
using WpfApp.ViewModels;

namespace WpfApp.Commands.Settings
{
    public abstract class SettingsSaveCommandBase : SettingsCommandBase
    {
        private bool _cancelClosingView = false;

        protected SettingsSaveCommandBase(SettingsViewModel settingsViewModel, ILogger logger) 
            : base(settingsViewModel, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            try
            {
                SaveSettings();
                Logger.WriteInfo(Resources.Message_Settings_were_updated);
            }
            catch (FileNotFoundException e)
            {
                var message = Logger.WriteError(Resources.Message_Cannot_save_settings_to_file, e);
                ServiceLocator.Get<HumanInteractionService>().ShowError(message);
                _cancelClosingView = true;
            }
        }

        protected override void FinalizeExecution(object parameter)
        {
            base.FinalizeExecution(parameter);
            if (!_cancelClosingView)
                CloseView();
        }

        protected abstract void SaveSettings();
    }
}