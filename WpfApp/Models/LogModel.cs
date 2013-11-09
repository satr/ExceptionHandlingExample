using System.Collections.ObjectModel;
using System.Linq;
using Common.Logging;
using WpfApp.Entities;

namespace WpfApp.Models
{
    public class LogModel: ILogSource
    {
        private readonly LogSeverity[] _logSeverities;
        public LogModel(params LogSeverity[] logSeverities)
        {
            _logSeverities = logSeverities;
            LogItems = new ObservableCollection<LogItem>();
        }

        public ObservableCollection<LogItem> LogItems { get; private set; }

        public void AddItem(LogSeverity logSeverity, string description)
        {
            if(_logSeverities.Contains(logSeverity))
                LogItems.Add(new LogItem(logSeverity, description));
        }
    }
}