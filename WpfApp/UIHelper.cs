using System.Windows;
using System.Windows.Controls;
using ExternalBLInterfaces;

namespace WpfApp
{
    class UIHelper
    {
        public static UIElement CreatePluginUIElement(IPlugin plugin)
        {
            var element = new Button
            {
                Content = plugin.Description,
                Command = new PluginCommand(plugin)
            };
            return element;
        }
    }
}