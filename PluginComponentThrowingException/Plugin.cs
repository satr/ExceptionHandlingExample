using System;
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
            Logger.WriteInfo(Common.Helpers.GetStringFormatUnchecked(Resources.Message_Plugin__0__is_starting, Description));
            try
            {
                DoWork();
            }
            catch (Exception e)
            {
                var message = Logger.WriteCritical(Resources.Message_Unexpected_error_occured_in_plugin, e);
                HumanInteractionService.ShowError(message);
            }
            Logger.WriteInfo(Common.Helpers.GetStringFormatUnchecked(Resources.Message_Plugin__0__finished, Description));
        }

        public string Description
        {
            get
            {
                return Resources.Title_Plugin_Throwing_Exception;
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
            //simulate critical error
            throw new Exception("Critical error occured");
        }
    }
}
