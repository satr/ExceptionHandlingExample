using System.Windows.Controls;
using System.Windows.Input;
using InternalComponent;
using WpfApp.BL;
using WpfApp.BL.Services;
using WpfApp.Commands;
using WpfApp.Commands.Books;
using WpfApp.Commands.Main;
using WpfApp.Helpers;
using WpfApp.Properties;

namespace WpfApp.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(Panel pluginElementPanel)
        {
            Storage.Logger.WriteInfo(Resources.Message_Initialization_started);
            var internalBL = new InternalBL(Storage.Logger);
            EditSettingsCommand = new EditSettingsCommand(Storage.Logger);
            ShowBooksCommand = new ShowBookListCommand(Storage.Logger);
            InternalComponentThrowingFileNotFoundCommand = new InternalComponentThrowingFileNotFoundExceptionCommand(internalBL, Storage.Logger);
            InternalComponentThrowingExceptionCommand = new InternalComponentThrowingExceptionCommand(internalBL, Storage.Logger);
            foreach (var plugin in PluginHelper.LoadPlugins(Storage.Logger, ServiceLocator.Get<HumanInteractionService>()))
            {
                pluginElementPanel.Children.Add(UIHelper.CreatePluginUIElement(plugin, Storage.Logger));
            }
            Storage.Logger.WriteInfo(Resources.Message_Initialization_completed);
        }

        public ICommand EditSettingsCommand { get; set; }
        public ICommand ShowBooksCommand { get; set; }
        public ICommand InternalComponentThrowingFileNotFoundCommand { get; set; }
        public ICommand InternalComponentThrowingExceptionCommand { get; set; }
    }
}