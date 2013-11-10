using Common.Logging;
using InternalComponent;

namespace WpfApp.Commands.Main
{
    public abstract class InternalComponentCommandBase : CommandBase
    {
        protected readonly InternalBL InternalBL;

        protected InternalComponentCommandBase(InternalBL internalBL, ILogger logger):base(logger)
        {
            InternalBL = internalBL;
        }
    }
}