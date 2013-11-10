using System;
using System.IO;
using Common.Logging;
using Common.Plugins;
using Common.Services;
using PluginComponent.Properties;

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
            Logger.WriteInfo(string.Format(Resources.Message_Plugin__0__is_starting, Description));
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                var message = Logger.WriteCritical(Resources.Message_Unexpected_error_occured_in_plugin, e);
                HumanInteractionService.ShowError(message);
            }
            Logger.WriteInfo(string.Format(Resources.Message_Plugin__0__finished, Description));
        }

        public string Description
        {
            get
            {
                return Resources.Title_Plugin_throwing_FileNotFoundException;
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
                Logger.WriteError(Resources.Message_Expected_file_not_found_in_plugin, e);
            } 
        }
    }

    internal class Worker
    {
        public void Do()
        {
            //simulate file not found error
            throw new FileNotFoundException("Expected file not found");
        }
    }
}
