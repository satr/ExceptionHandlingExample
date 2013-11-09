using System.IO;
using ExternalBLInterfaces;

namespace ExternalComponent
{
    public class ExternalBL : IExternalBL
    {
        public void DoWork()
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
