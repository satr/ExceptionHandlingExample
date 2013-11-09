namespace Common
{
    public interface ILogSource
    {
        void AddItem(LogSeverity logSeverity, string description);
    }
}