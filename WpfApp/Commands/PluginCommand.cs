using System;
using System.Windows.Input;
using Common;
using Common.Plugins;

namespace WpfApp.Commands
{
    public class PluginCommand : ICommand
    {
        private readonly IPlugin _plugin;

        public PluginCommand(IPlugin plugin)
        {
            _plugin = plugin;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _plugin.Run();
        }

        public event EventHandler CanExecuteChanged;
    }
}