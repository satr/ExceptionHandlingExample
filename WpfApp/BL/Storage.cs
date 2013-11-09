using Common;
using Common.Logging;

namespace WpfApp.BL
{
    class Storage
    {
        private static Logger _logger;

        public static ILogger Logger
        {
            get { return _logger ?? (_logger = new Logger()); }
        }
    }
}
