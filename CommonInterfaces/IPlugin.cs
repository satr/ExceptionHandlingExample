namespace Common
{
    public interface IPlugin
    {
        void Run();
        string Description { get; }
        ILogger Logger { get; set; }
    }
}