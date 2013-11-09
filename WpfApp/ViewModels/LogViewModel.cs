using System.Collections.ObjectModel;
using WpfApp.BL;
using WpfApp.Entities;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class LogViewModel
    {
        private readonly LogModel _logModel;

        public LogViewModel(LogModel logModel)
        {
            _logModel = logModel;
            Storage.Logger.AddSource(_logModel);
        }

        public ObservableCollection<LogItem> Log
        {
            get { return _logModel.LogItems; }
        } 
    }
}