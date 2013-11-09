namespace ExternalBLInterfaces
{
    public interface IPlugin
    {
        void Run();
        string Description { get; }
    }
}