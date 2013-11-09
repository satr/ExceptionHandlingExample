using System;
using System.Collections.Generic;
using System.Text;
using Common.Logging;

namespace WpfApp.BL
{
    internal class CompositeLogger : ILogger
    {
        private readonly List<ILogSource> _logSources = new List<ILogSource>();

        public void AddSource(ILogSource logSource)
        {
            _logSources.Add(logSource);
        }

        public void WriteCritical(string description)
        {
            Write(LogSeverity.Critical, description);
        }

        public string WriteCritical(string description, Exception exception)
        {
            return Write(LogSeverity.Critical, description, exception);
        }

        public void WriteError(string description)
        {
            Write(LogSeverity.Error, description);
        }

        public string WriteError(string description, Exception exception)
        {
            return Write(LogSeverity.Error, description, exception);
        }

        public void WriteWarning(string description)
        {
            Write(LogSeverity.Warning, description);
        }

        public void WriteInfo(string description)
        {
            Write(LogSeverity.Info, description);
        }

        private void Write(LogSeverity logSeverity, string description)
        {
            foreach (var logSource in _logSources)
            {
                logSource.AddItem(logSeverity, description);
            }
        }

        private string Write(LogSeverity logSeverity, string description, Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendLine(description);
            sb.AppendLine(exception.Message);
            var innerException = exception.InnerException;
            while (innerException != null)
            {
                sb.AppendLine(innerException.Message);
                innerException = innerException.InnerException;
            }
            var compositeDescription = sb.ToString();
            Write(logSeverity, compositeDescription);
            return compositeDescription;
        }
    }
}