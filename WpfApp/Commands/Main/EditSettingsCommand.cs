using Common.Logging;
using WpfApp.Views;

namespace WpfApp.Commands.Main
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