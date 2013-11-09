using InternalComponent;

namespace WpfApp
{
    public class DoWorkWithInternalBL1Command: DoWorkWithInternalBLCommandBase
    {
        public DoWorkWithInternalBL1Command(InternalBL internalBL) : base(internalBL)
        {
        }

        public override void Execute(object parameter)
        {
            InternalBL.MethodWhichInvokesPrivateMethodThrowingFileNotFoundException();
        }
    }
}