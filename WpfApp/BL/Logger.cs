using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Common.Logging;

namespace WpfApp.BL
{
    internal class Logger : ILogger
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

        public void WriteCritical(string description, Exception exception)
        {
            Write(LogSeverity.Critical, description, exception);
        }

        public void WriteError(string description)
        {
            Write(LogSeverity.High, description);
        }

        public void WriteError(string description, Exception exception)
        {
            Write(LogSeverity.High, description, exception);
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

        private void Write(LogSeverity logSeverity, string description, Exception exception)
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
            Write(logSeverity, sb.ToString());
        }
    }
}