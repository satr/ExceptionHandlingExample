using System;
using System.IO;
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
                return "Plugin throwing FileNotFoundException";
            }
        }

        public ILogger Logger { get; set; }
        public IHumanInteractionService HumanInteractionService { set; private get; }

        private void DoWork()
        {
            var worker = new Worker();
            try
            {
                worker.Do();
            }
            catch (FileNotFoundException e)
            {
                Logger.WriteError("Expected file not found in plugin.", e);
            } 
        }
    }

    internal class Worker
    {
        public void Do()
        {
            throw new FileNotFoundException("Expected file not found");
        }
    }
}
