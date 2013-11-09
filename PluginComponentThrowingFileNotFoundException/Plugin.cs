using System.IO;
using ExternalBLInterfaces;

namespace PluginComponent
{
    public class Plugin : IPlugin
    {
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
    }
}
