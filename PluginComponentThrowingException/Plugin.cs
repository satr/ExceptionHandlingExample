using System;
using Common;

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
            MethodThrowingException();
        }

        public string Description
        {
            get
            {
                return "Plugin Throwing Exception";
            }
        }

        public ILogger Logger { get; set; }

        private void MethodThrowingException()
        {
            throw new Exception("Unexpected error orrured");
        }
    }

}
