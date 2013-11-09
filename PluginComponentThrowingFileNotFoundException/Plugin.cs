using System.IO;
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
            MethodThrowingFileNotFoundException();
        }

        private void MethodThrowingFileNotFoundException()
        {
            throw new FileNotFoundException("Expected file not found");
        }

        public string Description
        {
            get
            {
                return "Plugin throwing FileNotFoundException";
            }
        }

        public ILogger Logger { get; set; }
    }
}
