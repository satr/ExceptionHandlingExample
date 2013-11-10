using Common.Logging;
using InternalComponent;

namespace WpfApp.Commands.Main
{
    public class InternalComponentThrowingExceptionCommand : InternalComponentCommandBase
    {
        public InternalComponentThrowingExceptionCommand(InternalBL internalBL, ILogger logger) : base(internalBL, logger)
        {
        }

        protected override void ExecuteInternal(object parameter)
        {
            InternalBL.MethodWhichInvokesPrivateMethodThrowingException();
        }
    }
}