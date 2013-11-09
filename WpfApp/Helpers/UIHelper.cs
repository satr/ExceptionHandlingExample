using System.Windows;
using System.Windows.Controls;
using Common;
using WpfApp.Commands;

namespace WpfApp.Helpers
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