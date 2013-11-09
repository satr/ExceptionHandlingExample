using System;
using Common;

namespace WpfApp.Entities
{
    public class LogItem
    {
        public LogSeverity Severity { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedOn { get; private set; }

        public LogItem(LogSeverity severity, string description)
        {
            Severity = severity;
            Description = description;
            CreatedOn = DateTime.Now;
        }
    }
}