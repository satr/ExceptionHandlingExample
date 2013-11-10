using System;
using System.IO;
using Common.Logging;
using InternalComponent.Properties;

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
            Logger.WriteInfo(Resources.Message_Internal_component_Throwing_FileNotFoundException_is_running);
            MethodThrowingFileNotFoundException();
            Logger.WriteInfo(Resources.Message_Internal_component_Throwing_FileNotFoundException_is_finishing);
        }

        public void MethodWhichInvokesPrivateMethodThrowingException()
        {
            Logger.WriteInfo(Resources.Message_Internal_component_Throwing_Exception_is_running);
            MethodThrowingException();
            Logger.WriteInfo(Resources.Message_Internal_component_Throwing_Exception_is_finishing);
        }

        private void MethodThrowingFileNotFoundException()
        {
            var worker = new Worker1();
            try
            {
                worker.Do();
            }
            catch (FileNotFoundException e)
            {
                Logger.WriteError(Resources.Message_Expected_file_not_found_in_internal_component, e);
            }
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
            //simulate file not found error
            throw new FileNotFoundException("Expected file not found");
        }
    }

    internal class Worker2
    {
        public void Do()
        {
            throw new Exception("Critical error occured");
        }
    }
}
