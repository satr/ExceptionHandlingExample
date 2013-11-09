using InternalComponent;

namespace WpfApp
{
    public class InternalComponentThrowingFileNotFoundExceptionCommand: InternalComponentCommandBase
    {
        public InternalComponentThrowingFileNotFoundExceptionCommand(InternalBL internalBL) : base(internalBL)
        {
        }

        public override void Execute(object parameter)
        {
            InternalBL.MethodWhichInvokesPrivateMethodThrowingFileNotFoundException();
        }
    }
}