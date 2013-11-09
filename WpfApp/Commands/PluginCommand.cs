using Common.Logging;
using Common.Plugins;

namespace WpfApp.Commands
{
    public class PluginCommand : CommandBase
    {
        private readonly IPlugin _plugin;

        public PluginCommand(IPlugin plugin, ILogger logger) : base(logger)
        {
            _plugin = plugin;
        }

        protected override void ExecuteInternal(object parameter)
        {
            Logger.WriteInfo(string.Format("Plugin {0} is starting", _plugin.Description));
            _plugin.Run();
            Logger.WriteInfo(string.Format("Plugin {0} finished", _plugin.Description));
        }
    }
}