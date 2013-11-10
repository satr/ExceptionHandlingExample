using Common.Logging;
using WpfApp.Entities;

namespace WpfApp.BL
{
    class Storage
    {
        private static CompositeLogger _logger;
        private static Settings _settings;

        public static ILogger Logger
        {
            get { return _logger ?? (_logger = new CompositeLogger()); }
        }

        public static Settings Settings
        {
            get { return _settings ?? (_settings = new Settings()); }
            set { _settings = value; }
        }
    }
}
