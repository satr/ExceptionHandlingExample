using System.Windows.Controls;
using System.Windows.Input;
using InternalComponent;

namespace WpfApp
{
    public class MainViewModel
    {
        public MainViewModel(Panel pluginElementPanel)
        {
            var internalBL = new InternalBL();
            InternalComponetntThrowingFileNotFoundCommand = new InternalComponentThrowingFileNotFoundExceptionCommand(internalBL);
            InternalComponentThrowingExceptionCommand = new InternalComponentThrowingExceptionCommand(internalBL);
            foreach (var plugin in PluginHelper.LoadPlugins())
            {
                pluginElementPanel.Children.Add(UIHelper.CreatePluginUIElement(plugin));
            }
        }


        public ICommand InternalComponetntThrowingFileNotFoundCommand { get; set; }
        public ICommand InternalComponentThrowingExceptionCommand { get; set; }
    }
}