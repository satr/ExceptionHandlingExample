using System.Windows;
using System.Windows.Controls;
using Common;
using Common.Logging;
using Common.Plugins;
using WpfApp.Commands;
using WpfApp.Commands.Main;

namespace WpfApp.Helpers
{
    class UIHelper
    {
        public static UIElement CreatePluginUIElement(IPlugin plugin, ILogger logger)
        {
            var element = new Button
            {
                Content = plugin.Description,
                Command = new PluginCommand(plugin, logger)
            };
            return element;
        }
    }
}