using System;
using System.IO;
using Common;
using Common.Logging;

namespace InternalComponent
{
    public class InternalBL
    {
        public ILogger Logger { get; set; }

        public InternalBL(ILogger logger)
        {
            Logger = logger;
        }

        public void MethodWhichInvokesPrivateMethodThrowingFileNotFoundException()
        {
            MethodThrowingFileNotFoundException();
        }

        private void MethodThrowingFileNotFoundException()
        {
            throw new FileNotFoundException("Expected file not found");
        }

        public void MethodWhichInvokesPrivateMethodThrowingException()
        {
            MethodThrowingException();
        }

        private void MethodThrowingException()
        {
            throw new Exception("Unexpected error orrured");
        }
    }
}
