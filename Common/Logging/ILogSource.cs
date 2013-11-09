namespace Common.Logging
{
    public interface ILogSource
    {
        void AddItem(LogSeverity logSeverity, string description);
    }
}