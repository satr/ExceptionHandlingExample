using System;
using System.IO;
using Common.Logging;
using Common.Plugins;

namespace PluginComponent
{
    public class Plugin : IPlugin
    {
        public Plugin()
        {
            Logger = new NullLogger();
        }

        public void Run()
        {
            Logger.WriteInfo(string.Format("Plugin {0} is starting", Description));
            DoWork();
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

        private void DoWork()
        {
            new Worker().Do();
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
