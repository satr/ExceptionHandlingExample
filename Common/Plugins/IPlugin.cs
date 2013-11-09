using Common.Logging;

namespace Common.Plugins
{
    public interface IPlugin
    {
        void Run();
        string Description { get; }
        ILogger Logger { get; set; }
    }
}