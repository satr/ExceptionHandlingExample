using System.Collections.ObjectModel;
using WpfApp.BL;
using WpfApp.Entities;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class LogViewModel
    {
        private readonly LogModel _logModel;

        public LogViewModel()
        {
            _logModel = new LogModel();
            Storage.Logger.AddSource(_logModel);
        }

        public ObservableCollection<LogItem> Log
        {
            get { return _logModel.LogItems; }
        } 
    }
}