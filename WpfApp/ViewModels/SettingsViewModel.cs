using System;
using System.Windows.Input;
using Common.Logging;
using WpfApp.Commands;
using WpfApp.Entities;

namespace WpfApp.ViewModels
{
    public class SettingsViewModel
    {
        public event EventHandler OnCloseView;

        public SettingsViewModel(Settings settings, ILogger logger)
        {
            SaveCorrectCommand = new SettingsSaveCorrectCommand(this, logger);
            SaveCriticalFailCommand = new SettingsSaveCriticalFailCommand(this, logger);
            SaveErrorCommand = new SettingsSaveErrorCommand(this, logger);
            CancelCommand = new SettingsCancelCommand(this, logger);
            NewSettings = (Settings) settings.Clone();
        }

        public ICommand CancelCommand { get; set; }
        public ICommand SaveCorrectCommand { get; set; }
        public ICommand SaveCriticalFailCommand { get; set; }
        public ICommand SaveErrorCommand { get; set; }

        public Settings NewSettings { get; private set; }

        public decimal NumericOption
        {
            get { return NewSettings.NumericOption; }
            set { NewSettings.NumericOption = value; }
        }

        public string TextOption
        {
            get { return NewSettings.TextOption; }
            set { NewSettings.TextOption = value; }
        }

        public void FireCloseView()
        {
            if (OnCloseView != null)
                OnCloseView(this, EventArgs.Empty);
        }
    }
}