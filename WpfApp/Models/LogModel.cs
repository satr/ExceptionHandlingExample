using System.Collections.ObjectModel;
using Common;
using Common.Logging;
using WpfApp.Entities;

namespace WpfApp.Models
{
    public class LogModel: ILogSource
    {
        public LogModel()
        {
            LogItems = new ObservableCollection<LogItem>();
        }

        public ObservableCollection<LogItem> LogItems { get; private set; }

        public void AddItem(LogSeverity logSeverity, string description)
        {
            LogItems.Add(new LogItem(logSeverity, description));
        }
    }
}