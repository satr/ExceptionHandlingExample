using System;

namespace Common.Logging
{
    public interface ILogger
    {
        void AddSource(ILogSource logSource);
        void WriteCritical(string description);
        string WriteCritical(string description, Exception exception);
        void WriteError(string description);
        string WriteError(string description, Exception exception);
        void WriteWarning(string description);
        void WriteInfo(string description);
    }
}
