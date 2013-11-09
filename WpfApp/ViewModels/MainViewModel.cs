using System.Windows.Controls;
using System.Windows.Input;
using InternalComponent;
using WpfApp.BL;
using WpfApp.BL.Services;
using WpfApp.Commands;
using WpfApp.Helpers;

namespace WpfApp.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(Panel pluginElementPanel)
        {
            Storage.Logger.WriteInfo("Initialization started.");
            var internalBL = new InternalBL(Storage.Logger);
            InternalComponentThrowingFileNotFoundCommand = new InternalComponentThrowingFileNotFoundExceptionCommand(internalBL, Storage.Logger);
            InternalComponentThrowingExceptionCommand = new InternalComponentThrowingExceptionCommand(internalBL, Storage.Logger);
            foreach (var plugin in PluginHelper.LoadPlugins(Storage.Logger, ServiceLocator.Get<HumanInteractionService>()))
            {
                pluginElementPanel.Children.Add(UIHelper.CreatePluginUIElement(plugin, Storage.Logger));
            }
            Storage.Logger.WriteInfo("Initialization complete.");
        }


        public ICommand InternalComponentThrowingFileNotFoundCommand { get; set; }
        public ICommand InternalComponentThrowingExceptionCommand { get; set; }
    }
}