using Common.Logging;
using Common.Services;

namespace Common.Plugins
{
    public interface IPlugin
    {
        void Run();
        string Description { get; }
        ILogger Logger { set; }
        IHumanInteractionService HumanInteractionService { set; }
    }
}