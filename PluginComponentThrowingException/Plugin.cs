using System;
using ExternalBLInterfaces;

namespace PluginComponent
{
    public class Plugin : IPlugin
    {
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

        private void MethodThrowingException()
        {
            throw new Exception("Unexpected error orrured");
        }
    }

}
