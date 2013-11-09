using System;

namespace Common
{
    public interface ILogger
    {
        void AddSource(ILogSource logSource);
        void WriteCritical(string description);
        void WriteCritical(string description, Exception exception);
        void WriteError(string description);
        void WriteError(string description, Exception exception);
        void WriteWarning(string description);
        void WriteInfo(string description);
    }
}
