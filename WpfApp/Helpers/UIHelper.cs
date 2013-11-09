using System.Windows;
using System.Windows.Controls;
using Common;
using Common.Plugins;
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