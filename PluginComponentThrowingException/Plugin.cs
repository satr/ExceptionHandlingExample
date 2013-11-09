using System;
using Common.Logging;
using Common.Plugins;
using Common.Services;

namespace PluginComponent
{
    public class Plugin : IPlugin
    {
        public Plugin()
        {
            Logger = new NullLogger();
            HumanInteractionService = new NullHumanInteractionService();
        }

        public void Run()
        {
            Logger.WriteInfo(string.Format("Plugin {0} is starting", Description));
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                var message = Logger.WriteCritical("Unexpected error occured in plugin.", e);
                HumanInteractionService.ShowError(message);
            }
            Logger.WriteInfo(string.Format("Plugin {0} finished", Description));
        }

        public string Description
        {
            get
            {
                return "Plugin Throwing Exception";
            }
        }

        public ILogger Logger { get; set; }
        public IHumanInteractionService HumanInteractionService { set; private get; }

        private void DoWork()
        {
            new Worker().Do();
        }
    }

    internal class Worker
    {
        public void Do()
        {
            throw new Exception("Some critical error occured");
        }
    }
}
