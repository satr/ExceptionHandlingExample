using Common.Logging;

namespace WpfApp.BL
{
    class Storage
    {
        private static CompositeLogger _logger;

        public static ILogger Logger
        {
            get { return _logger ?? (_logger = new CompositeLogger()); }
        }
    }
}
