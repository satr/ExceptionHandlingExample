using Common.Logging;
using Common.Plugins;
using WpfApp.Properties;

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
            Logger.WriteInfo(Common.Helpers.GetStringFormatUnchecked(Resources.Message_Plugin__0__is_starting, _plugin.Description));
            _plugin.Run();
            Logger.WriteInfo(Common.Helpers.GetStringFormatUnchecked(Resources.Message_Plugin__0__finished, _plugin.Description));
        }
    }
}