using Common.Logging;
using WpfApp.Commands;
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public class EditSettingsCommand: CommandBase
    {
        public EditSettingsCommand(ILogger logger) : base(logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            var settingsView = new SettingsView();
            settingsView.Show();
        }
    }
}