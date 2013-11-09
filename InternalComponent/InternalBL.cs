using System;
using System.IO;
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
            Logger.WriteInfo("Internal component Throwing FileNotFoundException is running");
            MethodThrowingFileNotFoundException();
            Logger.WriteInfo("Internal component Throwing FileNotFoundException is finishing");
        }

        public void MethodWhichInvokesPrivateMethodThrowingException()
        {
            Logger.WriteInfo("Internal component Throwing Exception is running");
            MethodThrowingException();
            Logger.WriteInfo("Internal component Throwing Exception is finishing");
        }

        private void MethodThrowingFileNotFoundException()
        {
            new Worker1().Do();
        }

        private void MethodThrowingException()
        {
            new Worker2().Do();
        }
    }

    internal class Worker1
    {
        public void Do()
        {
//            throw new FileNotFoundException("Expected file not found");
        }
    }

    internal class Worker2
    {
        public void Do()
        {
         //   throw new Exception("Unexpected error orrured");
        }
    }
}
