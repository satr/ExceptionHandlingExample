using Common.Logging;
using InternalComponent;

namespace WpfApp.Commands
{
    public class InternalComponentThrowingFileNotFoundExceptionCommand: InternalComponentCommandBase
    {
        public InternalComponentThrowingFileNotFoundExceptionCommand(InternalBL internalBL, ILogger logger) 
            : base(internalBL, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            InternalBL.MethodWhichInvokesPrivateMethodThrowingFileNotFoundException();
        }
    }
}