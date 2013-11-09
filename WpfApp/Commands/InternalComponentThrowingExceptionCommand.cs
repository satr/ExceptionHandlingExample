using InternalComponent;

namespace WpfApp.Commands
{
    public class InternalComponentThrowingExceptionCommand : InternalComponentCommandBase
    {
        public InternalComponentThrowingExceptionCommand(InternalBL internalBL) : base(internalBL)
        {
        }

        public override void Execute(object parameter)
        {
            InternalBL.MethodWhichInvokesPrivateMethodThrowingFileNotFoundException();
        }
    }
}