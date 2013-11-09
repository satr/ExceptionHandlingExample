using System.Windows.Controls;
using System.Windows.Input;
using InternalComponent;
using WpfApp.BL;
using WpfApp.Commands;
using WpfApp.Helpers;

namespace WpfApp.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(Panel pluginElementPanel)
        {
            var internalBL = new InternalBL(Storage.Logger);
            InternalComponetntThrowingFileNotFoundCommand = new InternalComponentThrowingFileNotFoundExceptionCommand(internalBL);
            InternalComponentThrowingExceptionCommand = new InternalComponentThrowingExceptionCommand(internalBL);
            foreach (var plugin in PluginHelper.LoadPlugins(Storage.Logger))
            {
                pluginElementPanel.Children.Add(UIHelper.CreatePluginUIElement(plugin));
            }
        }


        public ICommand InternalComponetntThrowingFileNotFoundCommand { get; set; }
        public ICommand InternalComponentThrowingExceptionCommand { get; set; }
    }
}