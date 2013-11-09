using System;

namespace Common.Logging
{
    public class NullLogger: ILogger
    {
        public void AddSource(ILogSource logSource)
        {
        }

        public void WriteCritical(string description)
        {
        }

        public string WriteCritical(string description, Exception exception)
        {
            return string.Empty;
        }

        public void WriteError(string description)
        {
        }

        public string WriteError(string description, Exception exception)
        {
            return string.Empty;
        }

        public void WriteWarning(string description)
        {
        }

        public void WriteInfo(string description)
        {
        }
    }
}
